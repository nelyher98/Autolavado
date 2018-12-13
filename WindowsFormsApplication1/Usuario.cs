using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autolavado
{   class Usuario
    {
        private int codi;
        private string cod;
        private string nombreEnc;
        private string contraseña;
        private string nombreEmp;
        private string apellido;
        private string tipo;
        private string placa;
        private string fecha;
        private int cantidad;
        private float precio;

        public Usuario()
        {

        }
        //SETTERS
        public void setFecha(string f) { fecha = f; }
        public void setcodi(int n) { codi = n; }
        public void setcod(string n) { cod = n; }
        public void setNombreEnc(string n) { nombreEnc = n; }
        public void setContraseña(string c) { contraseña = c; }
        public void setNombreEmp(string ne) { nombreEmp = ne; }
        public void setApellido(string ap) { apellido = ap; }
        public void setTipo(string t) { tipo = t; }
        public void setPlaca(string p) { placa = p; }
        public void setCantidad(int can) { cantidad = can; }
        public void setPrecio(float pre) { precio = pre; }
        //GETTERS
        public string getfecha() { return fecha; }
        public int getcodi() { return codi; }
        public string getCod() { return cod; }
        public string getNombreEnc() { return nombreEnc; }
        public string getContraseña() { return contraseña; }
        public string getNombreEmp() { return nombreEmp; }
        public string getApellido() { return apellido; }
        public string getTipo() { return tipo; }
        public string getPlaca() { return placa; }
        public int getCantidad() { return cantidad; }
        public float getPrecio() { return precio; }
    }
}