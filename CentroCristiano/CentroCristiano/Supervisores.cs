using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CentroCristiano
{
    
    class Supervisores
    {
        
        class Supervisor
        {
            public String nombre;
            public String cargo;
            public long id;
            public int pass;
            public Supervisor link;
        }

        static Supervisor ptrsupervisores;

        Supervisor AgregarSupervisores(Supervisor ptr, String nombre, String cargo, long id, int pass)
        {
            Supervisor p = new Supervisor();
            p.nombre = nombre;
            p.cargo = cargo;
            p.id = id;
            p.pass = pass;
            if (ptr == null)
            {
                ptr = p;
            }
            else
            {
                Supervisor q = ptr;
                while (q.link!=null)
                {
                    q = q.link;
                }
                q.link = p;
            }
            return ptr;
        }
        void CargarSupervisor(String URL)
        {
            string linea;
            System.IO.StreamReader file =
            new System.IO.StreamReader(URL);
            while ((linea = file.ReadLine()) != null)
            {
                String[] info = linea.Split(';');
                ptrsupervisores = AgregarSupervisores(ptrsupervisores,info[0],info[1],long.Parse(info[2]),int.Parse(info[3]));
            }
        }
        public static bool buscarSupervisor(long id, int clave)
        {
            Supervisor p = ptrsupervisores;
            while ((p.id != id && p.pass != clave) && p.link != null)
            {
                p = p.link;
            }
            if (p.id == id && p.pass == clave)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static String buscarNombre(long id)
        {
            Supervisor p = ptrsupervisores;
            while (p.id != id && p.link != null)
            {
                p = p.link;
            }
            if (p.id == id)
            {
                return p.cargo + " " + p.nombre;
            }
            else
            {
                return "";
            }

        }
        public Supervisores()
        {
            ptrsupervisores = null;
            CargarSupervisor("Supervisores.ccad");
        }
    }
}
