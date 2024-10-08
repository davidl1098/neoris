﻿using CuentaMovimientosService.Data;
using CuentaMovimientosService.Models;
using CuentaMovimientosService.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CuentaMovimientosService.Repositories.Implementations
{
    public class MovimientoRepository : IMovimientoRepository
    {
        private readonly ApplicationDbContext _context;

        public MovimientoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Movimiento> GetMovimientoByIdAsync(int id)
        {
            return await _context.Movimientos.FindAsync(id);
        }

        public async Task<IEnumerable<Movimiento>> GetAllMovimientosAsync()
        {
            return await _context.Movimientos.ToListAsync();
        }

        public async Task AddMovimientoAsync(Movimiento movimiento)
        {
            _context.Movimientos.Add(movimiento);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMovimientoAsync(Movimiento movimiento)
        {
            _context.Movimientos.Update(movimiento);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMovimientoAsync(int id)
        {
            var movimiento = await _context.Movimientos.FindAsync(id);
            if (movimiento != null)
            {
                _context.Movimientos.Remove(movimiento);
                await _context.SaveChangesAsync();
            }
        }
    }
}
