public class Matematica
{ 

    public double Somar(double x, double y)
    {
        return x + y;
    }

    public double Maior(double x, double y)
    {
        double maior = 0;

        if(x > y)
        {
            maior = x;    
        }
        else if(y > x)
        {
            maior = y;    
        }
        else if(x == y)
        {
            maior = x;     
        }

        return maior;
    }

    public double RaizQuadrada(double x)
    {
        return Math.Sqrt(x);
    }


}

