namespace TP9
{
    class Productos
    {
        string nombre;
        DateTime fechavencimiento;
        float precio;
        string tamanio;

        public Productos()
        {
            string [] nombres = {"Mayonesa", "Atun", "Carnemolida", "Tutuca" , "Ketchup" , "Jugo", "Crema de Leche", "Salsa", "File de pollo", "Costilla de Vaca"};
            Random p  = new Random();
            DateTime Fechaven = new DateTime();
            this.fechavencimiento = Fechaven.AddDays(p.Next(1 , 31));
            this.fechavencimiento = Fechaven.AddMonths(p.Next(1 , 12));
            this.fechavencimiento = Fechaven.AddYears(p.Next(2022, 2035));
            this.nombre = nombres[p.Next(0,9)];
            string [] tamanio = {"Pequeño", "Medio" , "Grande"};
            this.tamanio = tamanio[p.Next(0,2)];
            this.precio = p.Next(1000, 5000);
        }

        public Productos(string nombre, DateTime fechavencimiento, float precio, string tamanio)
        {
            this.Nombre = nombre;
            this.Fechavencimiento = fechavencimiento;
            this.Precio = precio;
            this.Tamanio = tamanio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fechavencimiento { get => fechavencimiento; set => fechavencimiento = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Tamanio { get => tamanio; set => tamanio = value; }

        
    }

    
}