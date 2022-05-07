﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{

    //create table detalle_venta(
    //IdDetalleVenta int primary key identity,
    //IdVenta int references Venta(IdVenta),
    //IdProducto int references producto(IdProducto),
    //Cantidad int,
    //Total decimal (10,2))
    public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public Venta oVenta { get; set; }
        public Producto oProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public string IdTransaccion { get; set; }
        
    }
}
