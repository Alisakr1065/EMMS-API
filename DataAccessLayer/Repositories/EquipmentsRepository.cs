using Data.Interfaces;
using Microsoft.Data.SqlClient;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class EquipmentsRepository : IEquipmentRepository
    {
        private readonly string _connectionString;
        public EquipmentsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        
        public async Task<int> AddEquipmentAsync(Equipment equipment)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_AddEquipment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (equipment != null)
                        {
                           command.Parameters.AddWithValue("@EquipmentName", equipment.EquipmentName ?? (object)DBNull.Value);
                           command.Parameters.AddWithValue("@EquipmentCode", equipment.EquipmentCode ?? (object)DBNull.Value);
                           command.Parameters.AddWithValue("@EquipmentTypeID", equipment.EquipmentTypeId);
                           command.Parameters.AddWithValue("@Location", equipment.Location ?? (object)DBNull.Value);
                           command.Parameters.AddWithValue("@InstallationDate", equipment.InstallationDate);
                           command.Parameters.AddWithValue("@Manufacturer", equipment.Manufacturer ?? (object)DBNull.Value);
                           command.Parameters.AddWithValue("@Model", equipment.Model ?? (object)DBNull.Value);
                           command.Parameters.AddWithValue("@SerialNumber", equipment.SerialNumber ?? (object)DBNull.Value);

                            var outputIdParam = new SqlParameter("@EquipmentID", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.Output
                            };
                            command.Parameters.Add(outputIdParam);

                             await connection.OpenAsync();
                            command.ExecuteNonQuery();

                            return (int)outputIdParam.Value;
                        }
                        else
                        {
                            return -1; // Invalid input
                        }
               
                }
            }
            }
            catch
            {
                return -1;
            }
        }

        public async Task<bool> DeleteEquipmentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Equipment>> GetAllEquipmentsAsync()
        {
            try
            {
                List<Equipment> equipments = new List<Equipment>();

                using (var Connection = new SqlConnection(_connectionString))
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

                        return equipments;
                    }
                }

            }
            catch
            {
                // Log the exception (not implemented here)
                throw;
            }
        }

        public async Task<Equipment> GetEquipmentByIdAsync(int id)
        {
            var equipment = new Equipment();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_GetEquipmentById", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@EquipmentID", id);

                        await connection.OpenAsync();

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.Read())
                            {
                                equipment.EquipmentId = reader.GetInt32("EquipmentID");
                                equipment.EquipmentName = reader.GetString("EquipmentName");
                                equipment.EquipmentCode = reader.GetString("EquipmentCode");
                                equipment.EquipmentType = reader.GetString("EquipmentType");
                                equipment.Location = reader.GetString("Location");
                                equipment.InstallationDate = reader.GetDateTime("InstallationDate");
                                equipment.Status = reader.GetString("Status");
                                equipment.Manufacturer = reader.GetString("Manufacturer");
                                equipment.Model = reader.GetString("Model");
                                equipment.SerialNumber = reader.GetString("SerialNumber");

                            }
                            else
                            {
                                return null; // No record found
                            }
                        }
                    }

                }
            }
            catch { }

            return equipment;
        }

        public async Task<List<Equipment>> GetEquipmentByStatusAsync(int statusId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateEquipmentAsync(Equipment equipment)
        {
            throw new NotImplementedException();
        }
    }
}
