using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;

namespace BlazorApp1.Data
{
    interface IRemoteService
    {
        [Get("/Tarea")]
        Task<List<Tarea>> GetAllTarea();

        //[Post("/Tarea")]
        //Task<Get<List<Tarea>> CrearTarea();
        
        
        [Get("/Usuario")]
        Task<List<Usuario>> GetAllUsuario();

        [Get("/Detalle")]
        Task<List<Detalle>> GetAllDetalle();

        [Get("/Recurso")]
        Task<List<Recurso>> GetAllRecurso();
    }
}
