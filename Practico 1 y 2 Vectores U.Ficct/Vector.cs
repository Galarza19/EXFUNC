using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_1_y_2_Vectores_U.Ficct
{
    class Vector
    {
        private int n;
        private int[] v;
        private int MAX = 201;
        public Vector()
        {
            n = 0;
            v = new int[MAX];
        }
        public void CargarRandom(int dato,int a,int b)
        {
            n = dato;
            Random r = new Random();
            for (int i=1;i<=n;i++)
            {
                v[i] = r.Next(a, b + 1);
            }

        }
        public string Descargar()
        {
            string s = "";
            for (int i = 1; i <= n; i++)
            {
                s=s+" | "+v[i] ;
            }
            return s;

        }
        //Ejercicio 1 serie multiplicadaor
        public void SerieM(int cant,int a,int m)
        {
            n = cant;

            for(int i=1;i<=n;i++)
            {
                v[i] = a;
                a = a*m;
            }
        }
        //Ejercicio 2 
        public void SerieFibo(int dato)
        {
            n = dato;
            int a = -1;
            int b = 1;
            int c = a + b;
            for (int i = 1; i <= n; i++)
            {
                v[i] = c;
                a = b;
                b = c;
                c = a + b;
            }
        }
        public double SerieFib(int dato)
        {
            SerieFibo(dato);//LLenar el vector con datos Fibo
            double f = 0;
            bool sw = true;
            double r = 2;//serie regular
            for (int i = 1; i <= n; i++)
            {
                if (sw == true)
                {
                    f = f + (v[i] / r);
                    r = r + 2;
                    sw = !sw;
                }
                else
                {
                    f = f - (v[i] / r);
                    r = r + 2;
                    sw = !sw;
                }
            }


            return f;
        }
        public string SerieFibo2()
        {
            string s = "";
            bool sw = true;
            double r = 2;//serie regular
            for (int i = 1; i <= n; i++)
            {
                if (sw == true)
                {
                    s = s + " + " + v[i] + " / " + r;
                    r = r + 2;
                    sw = !sw;
                }
                else
                {
                    s = s + " - " + v[i] + " / " + r;
                    r = r + 2;
                    sw = !sw;
                }
            }
            return s;

        }
        //Ejercicio 3 media mult
        public double MediaMult(int m)
        {
            int c = 0;
            double media = 0;
            for(int i=1;i<=n;i++)
            {
                if (i%m==0)
                {
                    c++;
                    media = media + v[i];
                }
            }
            media = (double)(media / c);
            return media;
        }
        //Ejercicio 4 
        public double MediaAyB(int a,int b)
        {
            double m = 0;
            int c=0;
           for(int i=a;i<=b;i++)
            {
                m=m + v[i];
                c++;

            }
            m = (double)m / c;
            return m;
        }
        //ejercicio  5
        public void Push(int dato)
        {
            n++;
            v[n] = dato;
        }
        public void EleMultyNoMult(int m,Vector v2,Vector v3)
        {
            v2.n = 0;
            v3.n = 0;
            for(int i=1;i<=n;i++)
            {
                if (v[i] % m == 0)
                {
                    v2.Push(v[i]);
                }
                else
                {
                    v3.Push(v[i]);
                }
            }
        }
        //ejercicio 6
        public bool VerifPrim(int num)
        {
            int  c=0;
            bool sw = false;
            for(int i=1;i<=num;i++)
            {
                if (num % i == 0)
                    c++;
            }
            if(c==2)
            {
                sw = true;
            }
            return sw;
        }
        public void ElimNoPrim()
        {
            for(int i=1;i<=n;i++)
            {
                if (!VerifPrim(v[i]))
                {
                    for(int j=i;j<=n-1;j++)
                    {
                        v[j] = v[j + 1];
                    }
                    n--;
                    i--;
                }

            }
        }
        //Ejercicio 7
        public bool Sincronizado()
        {
            bool sw=true;
            bool sw2 = true;
            for(int i=1;i<=n;i++)
            {
                if(sw2)
                {
                    if (!(v[i]%2==0))
                    {                    
                        sw = false; break;                    
                    }
                }
                else
                {
                    if ((v[i] % 2 == 0))
                    {
                        sw = false; break;
                    }
                }
                sw2 = !sw2;
            }
            return sw;
        }
        // ejercicio 8

        //ascendente
        public void BurbujaAsc()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    if (v[i] > v[j])// la  condicion determina  lo que va al final
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;

                    }
                }
            }
        }
        public void Purgar() //eliminar elementos iguales
        {
            int i, j, k;
            for (i = 1; i <= n; i++)
            {
                j = i + 1;
                while (j <= n)
                {
                    if (v[i] == v[j])
                    {
                        for (k = j; k <= n - 1; k++)
                        {
                            v[k] = v[k + 1];
                        }
                        n--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
        }
        public bool BusEle(int dato)
        {
            bool sw = false;
            for (int i = 1; i <= n; i++)
            {
                if (dato == v[i])
                    sw = true;

            }
            return sw;
        }
        public void Union(Vector v2, Vector v3)
        {
            v3.n = 0;
            for (int i = 1; i <= n; i++)
            {
                v3.Push(v[i]);
            }
            for (int i = 1; i <= v2.n; i++)
            {
                v3.Push(v2.v[i]);

            }
            //v[i],n,funciones
            v3.Purgar();
            v3.BurbujaAsc();
        }
        //ejercicio 9

        public void DifSimetrica(Vector v2, Vector v3)
        {
            v3.n = 0;
            for (int i = 1; i <= n; i++)//recorremos v1
            {
                if (!v2.BusEle(v[i]))
                    v3.Push(v[i]);
            }
            for (int i = 1; i <= v2.n; i++)//recorrer v2
            {
                if (!BusEle(v2.v[i]))
                    v3.Push(v2.v[i]);
            }
            v3.Purgar();
            v3.BurbujaAsc();
        }
        //Ejercicio 10
        public bool VerifOrd(int a,int b)
        {
            bool sw = true;
            for(int i=a;i<=b-1;i++)
            {
                if (sw)
                {
                    if (v[i] > v[i + 1])
                    {
                        sw = false; break;
                    }
                }               
            }
            return sw;
        }
     
       ///practico 2
       //Ejercicio 1
        public void EliminarRango(int a,int b)
        {
            int c = b - a + 1;
            for(int i=1;i<=c;i++)
            {
                for (int j = a; j <= n - 1; j++)
                {
                  v[j] = v[j + 1];
                }
                n--;               
            }
        }
        //Ejerciccio 2
        public int BusMenMul(int a, int b,int mult)
        {
             int m = v[b];
            int p = b;
            for (int i = a; i <= b; i++)
            {
                if (i%mult == 0)
                {
                    if (v[i] < m)
                    {
                        m = v[i];
                        p = i;
                    }
                }
            }
            return p;
        }
        public void OrdPosM(int m)
        {
            for(int i=1;i<=n;i++)
            {
                if(i%m==0)
                {
                    int p = BusMenMul(i, n,m);
                    int aux = v[i];
                    v[i] = v[p];
                    v[p] = aux;
                }
            }

        }
        // ejercicio 3

        public int BusMen(int a, int b)
        {
            int m = v[b];
            int p = b;
            for (int i = a; i <= b; i++)
            {
                if (v[i] < m)
                {
                    m = v[i];
                    p = i;
                }

            }
            return p;
        }
        public void Caracol()
        {
            int p;
            int k = n;
            int aux;
            bool sw = true;
            for (int i = 1; i <= k; i++)
            {
                if (sw)
                {
                    p = BusMen(i, k);
                    aux = v[i];
                    v[i] = v[p];
                    v[p] = aux; sw = !sw;
                }
                else
                {
                    p = BusMen(i, k);
                    aux = v[k];
                    v[k] = v[p];
                    v[p] = aux; sw = !sw;
                    k--;
                    i--;
                }
            }
        }
        //ejercicio 4
        //ejercicio 4
        public int Frec(int a, int b, int ele)
        {
            int f = 0;
            for (int i = a; i <= b; i++)
            {
                if (v[i] == ele)
                    f++;
            }
            return f;
        }
        public int EleDif(int a, int b)
        {
            int ele = 0;
            for (int i = a; i <= b; i++)
            {
                if (Frec(i, b, v[i]) == 1)
                {
                    ele++;
                }
            }
            return ele;
        }
      //Ejercicio 5
       public void MayorFrec(int a,int b,ref int f,ref int num)
       {
            f = Frec(a, b, v[b]);
            num = v[b];
            for (int i = a; i <= b; i++)
            {
                if (Frec(a, b, v[i])>f)
                {
                    f = Frec(a, b, v[i]);
                    num = v[i];
                }
            
            }
       }
        //Ejercicio 6
        //Encontrar la frecuencia de distribución de elementos del segmento entre a y b; 
        //si a=3 y b = 10
        //V={1,2,2,5,3,4,5,4,2,4,5,5,6,7}
        //Resultado elem{V={2,3,4,5)
        //          frec{V={2,1,3,2)
        public void EleyFrec(int a,int b,Vector v2,Vector v3)
        {
            v2.n = 0;
            v3.n = 0;
            for(int i=a;i<=b;i++)
            {
                v2.Push(v[i]);
            }
            v2.BurbujaAsc();
            v2.Purgar();
            for(int  i=1;i<=v2.n;i++)
            {
                int f = Frec(a,b, v2.v[i]);
                v3.Push(f);
            }
        }
        //Ejercicio 7
        //Encontrar elemento y frecuencia de los ELEMENTOS DE FIBONACCI.
        //Sea: V={4,3,2,9,1,2,3,4,5,4,5,6}
        //Resultado => elem{V={1,2,3,5}
        //             frec{V={1,2,1,2}
        public bool VerifFibo(int ele)
        {
            bool sw = false;
            int a = -1;
            int b = 1;
            int c = a + b; 
            while(c<=ele)
            {
                if(ele==c)
                {
                    sw = true;
                }
                a = b;
                b = c;
                c = a + b;

            }
            return sw;
        }
        public void EleyFrecFibo(Vector v2, Vector v3)
        {
            v2.n = 0;
            v3.n = 0;
            for(int i=1;i<=n;i++)
            {
                if (VerifFibo(v[i]))
                    v2.Push(v[i]);
            }
            v2.Purgar();
            v2.BurbujaAsc();
            for(int i=1;i<=v2.n;i++)
            {
                int f = Frec(1, n, v2.v[i]);
                v3.Push(f);
            }
        }
        //Ejercicio 8
        //Segmentar el Vector en elementos repetidos y no repetidos (con frecuencia y sin
        //frecuencia) ordenados descendentemente del segmento a y b.
        //Si a=4 y b=12 V={10,7,10,'5,4,6,7,8,4,5,7,5,'10,23,10,2}
        //el resultado es V={10,7,10,'7,7,5,5,5,4,4,8,6',10,23,10,2} primero con frecuencia y
        //ultimos sin frecuencia ordenados descendentemente.

        public void InterEle(int a,int b)
        {
            int aux = v[a];
            v[a] = v[b];
            v[b] = aux;
        }
        public void OrdDescF1(int a,int b)
        {
            for (int i = a; i <= b; i++)
            {
                if (Frec(a, b, v[i]) > 1)
                {
                    for (int j = i; j <= b; j++)
                    {
                        if (Frec(a, b, v[j]) > 1)
                        {
                            if (v[i] < v[j])
                            InterEle(i, j);
                        }
                    }
                }
            }
        }
        public void OrdDescF2(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                if (Frec(a, b, v[i]) == 1)
                {
                    for (int j = i; j <= b; j++)
                    {
                        if (Frec(a, b, v[j]) == 1)
                        {
                                if (v[i] < v[j])
                                InterEle(i, j);
                        }
                    }
                }
            }
        }
        public void SegmentarRepNoRep(int a, int b)
        {
            for(int i=a;i<=b;i++)
            {
                for(int j=i;j<=b;j++)
                {
                    if (Frec(a, b, v[i]) < Frec(a, b, v[j]))
                    {
                        InterEle(i, j);
                    }
                }
            }
            OrdDescF1(a, b);
            OrdDescF2(a, b);
        }
        //Ejercicio 9
        //Segmentar el Vector en capicúas y no capicúas, donde el 1er segmento este
        //ordenado ascendentemente y el 2do descendentemente.
        //V={555,44,60,71,81,44,555,71,20,44}
        //el resultado es V={44,44,44,555,555,81,71,71,60,20,}
        public bool VerifCap(int ele)
        {
            bool sw = false;
            int aux = ele;
            int cap = 0;
            while(aux>0)
            {
                cap = cap * 10 + aux % 10;
                aux = aux / 10;
            }
            if (cap == ele)
                sw = true;
            return sw;
        }
        public void OrdAscC1(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                if (VerifCap(v[i]))
                {
                    for (int j = i; j <= b; j++)
                    {
                        if (VerifCap(v[j]))
                        {
                            if (v[i] > v[j])
                                InterEle(i, j);
                        }
                    }
                }
            }
        }
        public void OrdDescC2(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                if (!VerifCap(v[i]))
                {
                    for (int j = i; j <= b; j++)
                    {
                        if (!VerifCap(v[j]))
                        {
                            if (v[i] < v[j])
                                InterEle(i, j);
                        }
                    }
                }
            }
        }
        public void SegmentarCapNoCap()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    if (!(VerifCap(v[i])))
                        InterEle(i, j);
                }
            }
            OrdAscC1(1,n);
            OrdDescC2(1,n);
        }
        //Ejercicio 10
        //Intercalar primos y no primos ordenados y mientras sea posible en el rango a y b
        //V={10,'11,5,6,7,8,4,5,13,'20,12} a=2 b=9
        //el resultado es: V={10,'5,4,5,6,7,8,11,13',20,12}
        public int CantPrim(int a,int b)
        {
            int cp = 0;
            for (int i = a; i <= b; i++)
            {
                if (VerifPrim(v[i]))
                    cp++;
                
            }
            return cp;
        }
        public int CantNoPrim(int a, int b)
        {
            int cp = 0;
            for (int i = a; i <= b; i++)
            {
                if (!VerifPrim(v[i]))
                    cp++;

            }
            return cp;
        }

        public int PosPrim(int a, int b)
        {
            int pp = 0;
            for (int i = a; i <= b; i++)
            {
                if (VerifPrim(v[i]))
                {
                    pp = i;break;
                }
            }
            return pp;
        }
        public int PosNoPrim(int a, int b)
        {
            int pp = 0;
            for (int i = a; i <= b; i++)
            {
                if (!VerifPrim(v[i]))
                {
                    pp = i; break;
                }
            }
            return pp;
        }
        public void IntercalarEle(int a,int b)
        {
            int pp = 0;
            int pnp = 0;
            for (int i=a;i<=b;i++)
           {
                int cp = CantPrim(i,b);
                int cnp = CantNoPrim(i,b);
                if((cp>0)&&(cnp>0))
                {
                    pp = PosPrim(i,b);
                    InterEle(i, pp);
                    pnp = PosNoPrim(i,b);
                    InterEle(i+1, pnp);
                    i++;
                }
               
            }
            OrdAscP1(a, b);
            OrdAscP2(a, b);
        }
        public void OrdAscP1(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                if (VerifPrim(v[i]))
                {
                    for (int j = i; j <= b; j++)
                    {
                        if (VerifPrim(v[j]))
                        {
                            if (v[i] > v[j])
                                InterEle(i, j);
                        }
                    }
                }
            }
        }
        public void OrdAscP2(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                if (!VerifPrim(v[i]))
                {
                    for (int j = i; j <= b; j++)
                    {
                        if (!VerifPrim(v[j]))
                        {
                            if (v[i] > v[j])
                                InterEle(i, j);
                        }
                    }
                }
            }
        }
        //clean
        public void Clean()
        { n = 0; }
    }
}
