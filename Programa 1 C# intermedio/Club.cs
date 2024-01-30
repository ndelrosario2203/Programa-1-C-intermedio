namespace Programa_1_C__intermedio
{
    class Club
    {
        public Club() {
            Socio1 = new Socio();
            Socio2 = new Socio();
            Socio3 = new Socio();
        }
        public Socio? Socio1 { get; set; }
        public Socio? Socio2 { get; set; }
        public Socio? Socio3 { get; set; }

        public void masAntiguo() {

            if (Socio1.Antiguedad > Socio2.Antiguedad && Socio1.Antiguedad > Socio3.Antiguedad)
            {
                Socio1.obtenerNombre();
            }
            else {
                if (Socio2.Antiguedad > Socio3.Antiguedad)
                {
                    Socio2.obtenerNombre();
                }
                else 
                { 
                    Socio3.obtenerNombre();
                }
            }
        
        }
            
    }
}
