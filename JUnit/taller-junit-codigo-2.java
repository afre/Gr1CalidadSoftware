    @Test
    public void probarMetodoEdad()
    {
        PruebaTest instance = new PruebaTest();
        assertEquals(22,instance.pruebaEdad(1994, 2, 26));
        assertEquals(22,instance.pruebaEdad(1994, 5, 1));
        assertEquals(2,instance.pruebaFibbonacci(3));
    }

    public int pruebaEdad(int anio, int mes, int dia)
    {
        Calendar fecha = new GregorianCalendar();
        int anioa = fecha.get(Calendar.YEAR);
        int mesa = fecha.get(Calendar.MONTH);
        int diaa = fecha.get(Calendar.DAY_OF_MONTH);
        int edad= anioa-anio;
        if(mesa<mes)
        {
            edad=edad-1;
        }
        if(mesa==mes)
        {
            if(diaa<dia)
            {
                edad=edad-1;
            }
            
        }
        return edad;
    }

 public int pruebaFibbonacci (int n)
    {
        if (n>1){
       return pruebaFibbonacci(n-1) + pruebaFibbonacci(n-2);  
    }
    else if (n==1) {  
        return 1;
    }
        return 0;
    }