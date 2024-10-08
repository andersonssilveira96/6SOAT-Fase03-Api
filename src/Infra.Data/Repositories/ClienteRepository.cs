﻿using Domain.Repositories;
using Domain.Entities;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly TechChallengeContext _context;
        public ClienteRepository(TechChallengeContext context)
        {
            _context = context;
        }
        public async Task<Cliente> ObterPorCPF(string cpf) => await _context.Cliente.FirstOrDefaultAsync(x => x.Cpf.Numero == cpf);
        public async Task<Cliente> ObterPorId(long id) => await _context.Cliente.FirstOrDefaultAsync(x => x.Id == id);
        public async Task<Cliente> Inserir(Cliente cliente)
        {
            if (cliente is null)
            {
                throw new ArgumentNullException(nameof(cliente));
            }

            _context.Cliente.Add(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public bool ValidaCliente(string cpf)
        {
            if (cpf is not null)
            { 
                return _context.Cliente.Any(u => u.Cpf.Numero == cpf);
            }

            throw new ArgumentNullException(nameof(cpf));
        }
    }
}
