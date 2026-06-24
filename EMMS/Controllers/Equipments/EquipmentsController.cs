using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Interfaces;
using Models;
using AutoMapper;
using Business.DTOs.Equipments;
using System.Dynamic;

namespace EMMS_API.Controllers.Equipments
{
    [Route("api/Equipments")]
    [ApiController]
    public class EquipmentsController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;
        private readonly IMapper _mapper;
        public EquipmentsController(IEquipmentService equipmentService, IMapper mapper)
        {
            _equipmentService = equipmentService;
            _mapper = mapper;
        }



        [HttpGet("Equipments", Name = "GetAllEquipments")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<EquipmentListDTO>>> GetAllEquipments()
        {


            var equipments = await _equipmentService.GetAllEquipmentsAsync();

            if(equipments == null)
                return NotFound("No Equipments Found");

            return Ok(equipments);
        }



        [HttpGet("Equipment/{id}", Name = "GetEquipmentById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EquipmentDetailsDTO>> GetEquipmentById(int id)
        {


            var equipment = await _equipmentService.GetEquipmentByIdAsync(id);

            if (equipment == null)
                return NotFound("Equipment not found");

            return Ok(_mapper.Map<EquipmentDetailsDTO>(equipment));
        }


        [HttpPost("Create", Name = "CreateEquipment")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<EquipmentDetailsDTO>> CreateEquipment([FromBody] CreateUpdateEquipmentDTO equipment)
        {


            if (equipment == null)
                return BadRequest("Invalid equipment data");

            var createdEquipment = await _equipmentService.
                AddEquipmentAsync(equipment);

            return CreatedAtRoute("GetEquipmentById", new { id = createdEquipment.EquipmentId }, createdEquipment);
            //return CreatedAtAction(nameof(GetEquipmentById), new { id = createdEquipment.Id }, createdEquipment);
        }

    }
}
