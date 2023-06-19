using apiGestores.Context;
using apiGestores.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiGestores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GestoresController : ControllerBase
    {

        private readonly AppDbContext context;

        public GestoresController(AppDbContext context)
        {
            this.context = context;
        }
        
        /// <summary>
        /// Listado de Gestores
        /// </summary>
        /// <returns></returns>

        // GET: api/<GestoresController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.gestores_bd.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Busqueda de un Gestor en la Base de Datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET api/<GestoresController>/5
        [HttpGet("{id}", Name ="GetGestor")]
        public ActionResult Get(int id)
        {
            try
            {
                var gestor = context.gestores_bd.FirstOrDefault(g => g.id == id);
                return Ok(gestor);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Agregar un Gestor 
        /// </summary>
        /// <param name="gestor"></param>
        /// <returns></returns>

        // POST api/<GestoresController>
        [HttpPost]
        public ActionResult Post([FromBody]Gestores_Bd gestor)
        {
            try
            {
                context.gestores_bd.Add(gestor);
                context.SaveChanges();
                return CreatedAtRoute("GetGestor", new { id = gestor }, gestor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Modificar Información de Gestor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="gestor"></param>
        /// <returns></returns>

        // PUT api/<GestoresController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Gestores_Bd gestor)
        {
            try
            {
                if (gestor.id==id)
                {
                    context.Entry(gestor).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetGestor", new { id = gestor }, gestor);
                }
                else
                {
                    return BadRequest();
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Borrar un Gestor de la Base de Datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // DELETE api/<GestoresController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var gestor = context.gestores_bd.FirstOrDefault(g => g.id == id);
                if (gestor!= null)
                {
                    context.gestores_bd.Remove(gestor);
                    context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
