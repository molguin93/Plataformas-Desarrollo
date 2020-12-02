﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;

namespace BlazorApp1.Data
{
    interface IRemoteService
    {
        // Métodos de Tarea
        [Get("/Tarea")]
        Task<List<Tarea>> GetAllTarea();

        [Get("/Tarea/{id}")]
        Task<Tarea> GetTarea(int id);

        [Post("/Tarea")]
        Task<Tarea> GuardarTarea(Tarea valor);

        [Delete("/Tarea/{id}")]
        Task<Tarea> BorrarTarea(int id);

        // Métodos de Usuario
        [Get("/Usuario")]
        Task<List<Usuario>> GetAllUsuario();

        [Get("/Usuario/{id}")]
        Task<Usuario> GetUsuario(int id);

        [Post("/Usuario")]
        Task<Usuario> GuardarUsuario(Usuario valor);

        [Delete("/Usuario/{id}")]
        Task<Usuario> BorrarUsuario(int id);

        // Métodos de Detalle
        [Get("/Detalle")]
        Task<List<Detalle>> GetAllDetalle();

        [Get("/Detalle/{id}")]
        Task<Detalle> GetDetalle(int id);

        [Post("/Detalle")]
        Task<Detalle> GuardarDetalle(Detalle valor);

        [Delete("/Detalle/{id}")]
        Task<Detalle> BorrarDetalle(int id);

        // Métodos de Recurso
        [Get("/Recurso")]
        Task<List<Recurso>> GetAllRecurso();

        [Get("/Recurso/{id}")]
        Task<Recurso> GetRecurso(int id);

        [Post("/Recurso")]
        Task<Recurso> GuardarRecurso(Recurso valor);

        [Delete("/Recurso/{id}")]
        Task<Recurso> BorrarRecurso(int id);
    }
}
