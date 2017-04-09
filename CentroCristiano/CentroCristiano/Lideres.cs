using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CentroCristiano
{
    
    class Lideres
    {
        
        public class Lider
        {
            public String nombre;
            public String cargo;
            public long id;
            public int pass;
            public Lider link;
        }

        public static Lider ptrlider;

        Lider AgregarLideres(Lider ptr, String nombre, String cargo, long id, int pass)
        {
            Lider p = new Lider();
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
                Lider q = ptr;
                while (q.link!=null)
                {
                    q = q.link;
                }
                q.link = p;
            }
            return ptr;
        }
        void CargarPastor(String URL)
        {
            string linea;
            System.IO.StreamReader file =
            new System.IO.StreamReader(URL);
            while ((linea = file.ReadLine()) != null)
            {
                String[] info = linea.Split(';');
                ptrlider = AgregarLideres(ptrlider,info[0],info[1],long.Parse(info[2]),int.Parse(info[3]));
            }
        }
        public static bool BuscarLider(long id, int clave)
        {
            Lider p = ptrlider;
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
        public static Lider BuscarLider(long id)
        {
            Lider p = ptrlider;
            while ((p.id != id) && p.link != null)
            {
                p = p.link;
            }
            if (p.id == id)
            {
                p.link = null;
                return p;
            }
            else
            {
                return null;
            }

        }
        public static String BuscarNombre(long id)
        {
            Lider p = ptrlider;
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
                return "no esta";
            }

        }

        public static Lider AgregarLideres(Lider ptr, string lideres)
        {
            string[] lid = lideres.Split(',');
            foreach (string id in lid)
            {
                Lider p = BuscarLider(long.Parse(id));
                if (ptr == null)
                {
                    ptr = p;
                }
                else
                {
                    Lider q = ptr;
                    while (q.link != null)
                    {
                        q = q.link;
                    }
                    q.link = p;
                }
            }
            return ptr;
        }

        public Lideres()
        {
            ptrlider = null;
            CargarPastor("Lideres.ccad");
        }
    }
}
