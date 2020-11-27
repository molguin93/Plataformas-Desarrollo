﻿using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuarioService
    {
        //private TareasDbContext ctx;

        //public UsuarioService(TareasDbContext _context)
        //{
        //    ctx = _context;
        //}

        // Metodos de Usuarios (User)
        public async Task<List<Usuario>> ListUser()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllUsuario();
        }

        public async Task<Usuario> SelectUser(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetUsuario(id);
        }

        public async Task<Usuario> SaveUser(Usuario value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GuardarUsuario(value);
        }

            public async Task<bool> DeleteUser(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            await remoteService.BorrarUsuario(id);
            return true;
        }

        //public async Task<Usuario> SaveUser2(int id, Usuario value)
        //{
        //    var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
        //    return await remoteService.GuardarUsuario2(id, value);
        //}
    }
}
