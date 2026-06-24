using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Models;
using System.Data;

namespace EMMS_API.Controllers.Faults
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaultsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetFaults()
        {
            List<Equipment> equipments = new List<Equipment>();

            using (var Connection = new SqlConnection("Server=localhost;Database=ElectricalMaintenanceDB;Integrated Security=True;TrustServerCertificate=True;Connection Timeout=30;"))
            {
                using (var Command = new SqlCommand("sp_GetAllEquipments", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    await Connection.OpenAsync();

                    using (var Reader = await Command.ExecuteReaderAsync())
                    {
                        while (Reader.Read())
                        {
                            var equipment = new Equipment
                            {
                                EquipmentId = Reader.GetInt32("EquipmentID"),
                                EquipmentName = Reader.GetString("EquipmentName"),
                                EquipmentCode = Reader.GetString("EquipmentCode"),
                                EquipmentType = Reader.GetString("EquipmentType"),
                                Location = Reader.GetString("Location"),
                                InstallationDate = Reader.GetDateTime("InstallationDate"),
                                Status = Reader.GetString("Status"),
                                Manufacturer = Reader.GetString("Manufacturer"),
                                Model = Reader.GetString("Model"),
                                SerialNumber = Reader.GetString("SerialNumber")
                            };
                            equipments.Add(equipment);
                        }
                    }

                }
            }

            return Ok();
        }
    }
}
