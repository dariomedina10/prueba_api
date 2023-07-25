using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace prueba_api.Controllers
{
    public class EmpleadosController : ApiController
    {
        private AsistenciaEntities Context = new AsistenciaEntities();
        //     private Meru_LinkEntities db = new Meru_LinkEntities();

        [HttpGet]
        public IEnumerable<empleado> Get()
        {
            using (AsistenciaEntities db = new AsistenciaEntities())
            {
                // var userJson = JsonSerializer.Serialize<User>(user);

                return db.empleados.ToList();

            }
        }

        [HttpGet]
        //hecho por dario medina
        public empleado Get(int id)
        {

            using (AsistenciaEntities db = new AsistenciaEntities())
            {
                return db.empleados.FirstOrDefault(x => x.id_empl == id);

            }


        }

        //[HttpPost]

        //public IHttpActionResult AgregarCargo([FromBody] Cargos cargo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Context.Cargos.Add(cargo);
        //        Context.SaveChanges();
        //        return Ok(cargo);

        //    }
        //    else
        //    {

        //        return BadRequest();

        //    }

        //}

        //[HttpPut]

        //public IHttpActionResult ActualizarCargo(int id, [FromBody] Cargos cargo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var cargoexiste = Context.Cargos.Count(e => e.Departamento_id == id) > 0;
        //        if (cargoexiste)
        //        {
        //            Context.Entry(cargo).State = EntityState.Modified;
        //            Context.SaveChanges();
        //            return Ok(cargo);
        //        }
        //        else
        //        {
        //            return NotFound();
        //        }
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }


        //}

        //[HttpDelete]
        //public IHttpActionResult EliminarCargo(int id)
        //{
        //    var cargo = Context.Cargos.Find(id);

        //    if (cargo != null)

        //    {
        //        Context.Cargos.Remove(cargo);
        //        Context.SaveChanges();
        //        return Ok(cargo);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }


        //}

    }
}
