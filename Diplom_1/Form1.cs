using System;
using System.Windows.Forms;
using System.Threading;

namespace Diplom_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void NachUslov()
        {
            for (int i = 0; i <= TaskApprox.n; i++) TaskApprox.t[i] = i * TaskApprox.h;

            for (int i = 0; i <= TaskApprox.n; i++) TaskApprox.uApprox[TaskApprox.kFirst, i] = TaskApprox.t[i] + 1;

            TaskApprox.x1Approx[0] = 1;
            TaskApprox.x2Approx[0] = -1;
        }

        public void startCalc()
        {
            int integNum = 0;
            int gradMethod = 0;

            if (radioTrapec.Checked) integNum = 0;
            else
            {
                if (radioLevixPram.Checked) integNum = 1;
                else
                {
                    if (radioSimpson.Checked) integNum = 2;
                    else integNum = 3;
                }
            }

            if (radioPontrGalerk.Checked) gradMethod = 0;
            else gradMethod = 1;

            SistemMethods.calc(TaskApprox.t, TaskApprox.x1Approx, TaskApprox.x2Approx, TaskApprox.uApprox, TaskApprox.kFirst);

            TaskApprox.IApprox[TaskApprox.kFirst] = IntegralMethods.calc(integNum, TaskApprox.x1Approx, TaskApprox.uApprox, TaskApprox.kFirst) + (TaskApprox.x1Approx[TaskApprox.n] - 3) * (TaskApprox.x1Approx[TaskApprox.n] - 3) + TaskApprox.x2Approx[TaskApprox.n] * TaskApprox.x2Approx[TaskApprox.n];
            
            do
            {
                if (TaskApprox.usuallyCount) { TaskApprox.kFirst = 0; TaskApprox.kLast = 1; TaskApprox.usuallyCount = false; }
                else { TaskApprox.kLast = 0; TaskApprox.kFirst = 1; TaskApprox.usuallyCount = true; }

                SistemMethods.calc(TaskApprox.t, TaskApprox.x1Approx, TaskApprox.x2Approx, TaskApprox.uApprox, TaskApprox.kFirst);


                if (gradMethod == 1)
                {
                    double sum=0;
                    GradMethods.hu = (TaskApprox.uApprox[TaskApprox.kFirst, 0] + TaskApprox.uApprox[TaskApprox.kFirst, TaskApprox.n]) / TaskApprox.n;

                    sum += ((TaskApprox.x1Approx[0] - TaskApprox.uApprox[TaskApprox.kFirst, 0] - 2) * (TaskApprox.x1Approx[0] - TaskApprox.uApprox[TaskApprox.kFirst, 0] - 2) + (TaskApprox.x1Approx[TaskApprox.n] - TaskApprox.uApprox[TaskApprox.kFirst, TaskApprox.n] - 2)*(TaskApprox.x1Approx[TaskApprox.n] - TaskApprox.uApprox[TaskApprox.kFirst, TaskApprox.n] - 2)) / 2;
                    for (int i = 1; i < TaskApprox.n; i++) sum += (TaskApprox.x1Approx[i] - TaskApprox.uApprox[TaskApprox.kFirst, i] - 2) * (TaskApprox.x1Approx[i] - TaskApprox.uApprox[TaskApprox.kFirst, i] - 2);

                    GradMethods.Iu = TaskApprox.h*sum + (TaskApprox.x1Approx[TaskApprox.n] - 3) * (TaskApprox.x1Approx[TaskApprox.n] - 3) + TaskApprox.x2Approx[TaskApprox.n] * TaskApprox.x2Approx[TaskApprox.n];

                    sum = 0;
                    sum += ((TaskApprox.x1Approx[0] - TaskApprox.uApprox[TaskApprox.kFirst, 0] - GradMethods.hu - 2) * (TaskApprox.x1Approx[0] - TaskApprox.uApprox[TaskApprox.kFirst, 0] - GradMethods.hu - 2) + (TaskApprox.x1Approx[TaskApprox.n] - TaskApprox.uApprox[TaskApprox.kFirst, TaskApprox.n] - GradMethods.hu - 2) * (TaskApprox.x1Approx[TaskApprox.n] - TaskApprox.uApprox[TaskApprox.kFirst, TaskApprox.n] - GradMethods.hu - 2)) / 2;
                    for (int i = 1; i < TaskApprox.n; i++) sum += (TaskApprox.x1Approx[i] - TaskApprox.uApprox[TaskApprox.kFirst, i] - GradMethods.hu - 2) * (TaskApprox.x1Approx[i] - TaskApprox.uApprox[TaskApprox.kFirst, i] - GradMethods.hu - 2);

                    GradMethods.Iuh = TaskApprox.h * sum + (TaskApprox.x1Approx[TaskApprox.n] - 3) * (TaskApprox.x1Approx[TaskApprox.n] - 3) + TaskApprox.x2Approx[TaskApprox.n] * TaskApprox.x2Approx[TaskApprox.n];
                }
                for (int i = 0; i <= TaskApprox.n; i++)
                {
                    TaskApprox.grad[i] = GradMethods.calc(gradMethod, i, TaskApprox.t[i], TaskApprox.x1Approx[i], TaskApprox.x2Approx[i], TaskApprox.uApprox[TaskApprox.kFirst, i], TaskApprox.x1Approx[TaskApprox.n], TaskApprox.x2Approx[TaskApprox.n]);

                    //normaZnam += gradI[i] * gradI[i];

                    double alfaFirst = GradMethods.alfak(TaskApprox.x1Approx[i], TaskApprox.uApprox[TaskApprox.kFirst, i], TaskApprox.grad[i], TaskApprox.x1Approx[TaskApprox.n], TaskApprox.x2Approx[TaskApprox.n]);

                    TaskApprox.uApprox[TaskApprox.kLast, i] = TaskApprox.uApprox[TaskApprox.kFirst, i] - alfaFirst * TaskApprox.grad[i];
                }

                TaskApprox.IApprox[TaskApprox.kLast] = IntegralMethods.calc(integNum, TaskApprox.x1Approx, TaskApprox.uApprox, TaskApprox.kLast) + (TaskApprox.x1Approx[TaskApprox.n] - 3) * (TaskApprox.x1Approx[TaskApprox.n] - 3) + TaskApprox.x2Approx[TaskApprox.n] * TaskApprox.x2Approx[TaskApprox.n]; ;

            } while (Math.Abs(TaskApprox.IApprox[TaskApprox.kLast] - TaskApprox.IApprox[TaskApprox.kFirst]) > TaskApprox.eps);

            vivod();
        }

        public void vivod()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i <= TaskApprox.n; i++)
            {
                if (i%10==0) dataGridView1.Rows.Add(i, TaskApprox.t[i], TaskReal.uReal[i], TaskApprox.uApprox[TaskApprox.kLast, i], TaskReal.x1Real[i], TaskReal.x2Real[i], TaskApprox.x1Approx[i], TaskApprox.x2Approx[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaskReal.calc();

            NachUslov();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startCalc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha f2 = new Zadacha();
            f2.Hide();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Funkcii f3 = new Funkcii();
            f3.Hide();
            f3.Show();
        }

    }

    static class SistemMethods
    {
        public static double k1, k2, k3, k4,
                        l1, l2, l3, l4;

        public static void calc(double[] t, double[] x1, double[] x2, double[,] u, int whichU)
        {           
            for (int i = 0; i < TaskApprox.n; i++)
            {
                k1 = TaskApprox.F1(i, t[i], x1[i], x2[i]) + u[whichU, i] * TaskApprox.delta(i);
                l1 = TaskApprox.F2(t[i], x1[i], x2[i]);

                k2 = TaskApprox.F1(i, t[i] + TaskApprox.h / 2, x1[i] + TaskApprox.h * k1 / 2, x2[i] + TaskApprox.h * l1 / 2) + u[whichU, i] * TaskApprox.delta(i);
                l2 = TaskApprox.F2(t[i] + TaskApprox.h / 2, x1[i] + TaskApprox.h * k1 / 2, x2[i] + TaskApprox.h * l1 / 2);

                k3 = TaskApprox.F1(i, t[i] + TaskApprox.h / 2, x1[i] + TaskApprox.h * k2 / 2, x2[i] + TaskApprox.h * l2 / 2) + u[whichU, i] * TaskApprox.delta(i);
                l3 = TaskApprox.F2(t[i] + TaskApprox.h / 2, x1[i] + TaskApprox.h * k2 / 2, x2[i] + TaskApprox.h * l2 / 2);

                k4 = TaskApprox.F1(i, t[i] + TaskApprox.h, x1[i] + TaskApprox.h * k3, x2[i] + TaskApprox.h * l3) + u[whichU, i] * TaskApprox.delta(i);
                l4 = TaskApprox.F2(t[i] + TaskApprox.h, x1[i] + TaskApprox.h * k3, x2[i] + TaskApprox.h * l3);

                x1[i + 1] = x1[i] + TaskApprox.h * (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                x2[i + 1] = x2[i] + TaskApprox.h * (l1 + 2 * l2 + 2 * l3 + l4) / 6;
            }
        }
    }

    //***********************************************************************

    static class IntegralMethods
    {
        public static double calc(int integNumber, double[] x1, double[,] u, int whichU)
        {
            double sum = 0;

            if (integNumber == 0)
            {
                sum += ((x1[0] - u[whichU, 0] - 2) * (x1[0] - u[whichU, 0] - 2) + (x1[TaskApprox.n] - u[whichU, TaskApprox.n] - 2) * (x1[TaskApprox.n] - u[whichU, TaskApprox.n] - 2)) / 2;
                for (int i = 1; i < TaskApprox.n; i++) sum += (x1[i] - u[whichU, i] - 2) * (x1[i] - u[whichU,i] - 2);
            }
            else if (integNumber == 1)
            {
                for (int i = 0; i < TaskApprox.n; i++) sum += (x1[i] - u[whichU, i] - 2) * (x1[i] - u[whichU, i] - 2);
                
            }
            else if (integNumber == 2)
            {
                for (int i = 0; i <= TaskApprox.n; i++)
                {
                    if (i == 0 || i == TaskApprox.n) sum += (x1[i] - u[whichU, i] - 2) * (x1[i] - u[whichU, i] - 2);
                    else
                    {
                        if (i % 2 == 0) sum += 2 * (x1[i] - u[whichU, i] - 2) * (x1[i] - u[whichU, i] - 2);
                        else sum += 4 * (x1[i] - u[whichU, i] - 2) * (x1[i] - u[whichU, i] - 2);
                    }
                }

                sum /= 3;
            }
            else
            {
                for (int i = 1; i <= TaskApprox.n; i++) sum += (x1[i] - u[whichU, i] - 2) * (x1[i] - u[whichU, i] - 2);
            }
            
            sum *= TaskApprox.h;
            
            return sum;
        }
    }

    //**********************************************************************

    static class GradMethods
    {
        public static double hu;
        public static double Iu, Iuh;

        public static double alfak(double x1, double uFirsti, double gradI, double x1n, double x2n)
        {
            double epsAlfa = Math.Pow(10, -1);
            double alfa1, alfa2, a1, b1, h1 = 0.05;
            int i = 1;

            do
            {
                b1 = i * h1;
                a1 = (i - 1) * h1;

                i++;
                
            } while (falfa(x1, uFirsti, a1, gradI, x1n, x2n) > falfa(x1, uFirsti, b1, gradI, x1n, x2n));
            
            b1 = b1 - h1;
            a1 = a1 - h1;

            alfa1 = b1 - (b1 - a1) * 2 / (1 + Math.Pow(5, 0.5));
            alfa2 = a1 + (b1 - a1) * 2 / (1 + Math.Pow(5, 0.5));

            do
            {
                if (falfa(x1, uFirsti, alfa1, gradI, x1n, x2n) < falfa(x1, uFirsti, alfa2, gradI, x1n, x2n))
                {
                    b1 = alfa2;
                    alfa2 = alfa1;
                    alfa1 = b1 - (b1 - a1) * 2 / (1 + Math.Pow(5, 0.5));
                }
                else
                {
                    a1 = alfa1;
                    alfa1 = alfa2;
                    alfa2 = a1 + (b1 - a1) * 2 / (1 + Math.Pow(5, 0.5));
                }

            } while (Math.Abs(b1 - a1) > epsAlfa);

            return (a1 + b1) / 2;
        }

        private static double falfa(double x1, double uFirsti, double alfa, double gradI, double x1n, double x2n)
        {
            return (x1 - uFirsti + alfa * gradI - 2) * (x1 - uFirsti + alfa * gradI - 2) * (TaskApprox.b - TaskApprox.a) + (x1n - 3) * (x1n - 3) + x2n * x2n;
        }

        public static double calc(int gradMethod, int j, double t, double x1, double x2, double u, double x1n, double x2n)
        {
            double h = TaskApprox.h;

            if (gradMethod == 0)
            {

                double[] psi1 = new double[TaskApprox.n + 1];
                double k1, k2, k3, k4;

                double[] psi2 = new double[TaskApprox.n + 1];
                double l1, l2, l3, l4;

                psi1[TaskApprox.n] = -2 * (x1n - 3);
                psi2[TaskApprox.n] = -2 * x2n;

                for (int i = TaskApprox.n; i > 0; i--)
                {
                    k1 = F1OfPsi(t, x1, x2, u, psi1[i], psi2[i]);
                    l1 = F2OfPsi(t, x1, x2, u, psi1[i], psi2[i]);

                    k2 = F1OfPsi(t + h / 2, x1, x2, u, psi1[i] + h / 2 / k1, psi2[i] + h * l1 / 2);
                    l2 = F2OfPsi(t + h / 2, x1, x2, u, psi1[i] + h / 2 / k1, psi2[i] + h * l1 / 2);

                    k3 = F1OfPsi(t + h / 2, x1, x2, u, psi1[i] + h * k2 / 2, psi2[i] + h * l2 / 2);
                    l3 = F2OfPsi(t + h / 2, x1, x2, u, psi1[i] + h * k2 / 2, psi2[i] + h * l2 / 2);

                    k4 = F1OfPsi(t + h, x1, x2, u, psi1[i] + h * k3, psi2[i] + h * l3);
                    l4 = F2OfPsi(t + h, x1, x2, u, psi1[i] + h * k3, psi2[i] + h * l3);

                    psi1[i - 1] = psi1[i] - h * (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                    psi2[i - 1] = psi2[i] - h * (l1 + 2 * l2 + 2 * l3 + l4) / 6;
                }

                return -2 * (x1 - u - 2) + psi1[j];
            }
            else
            {
                return (GradMethods.Iuh - GradMethods.Iu)/GradMethods.hu;
            }
        }

        private static double F1OfPsi(double t, double x1, double x2, double u, double psi1, double psi2)
        {
            return -2 * (x1 - u - 2) + 3 * psi1 * t + psi2;
        }

        private static double F2OfPsi(double t, double x1, double x2, double u, double psi1, double psi2)
        {
            return psi1 - psi2;
        }
    }

    //**********************************************************************
    
    static class TaskApprox
    {
        public static int  n=1000;
        public static double eps = 0.001;

        public static double[] t = new double[n + 1];

        public static double[] x1Approx = new double[n + 1];
        public static double[] x2Approx = new double[n + 1];

        public static double[,] uApprox = new double[2,n + 1];

        public static double[] grad = new double[n + 1];

        public static double[] IApprox = new double[2];

        public static double a = 0, b = 1, h = (b - a) / n;

        public static int kFirst = 0, kLast = 1;

        public static bool usuallyCount = true;

        public static double F1(int i,double t,double x1,double x2)
        {
            return 3*t*x1+x2+3-7*t*t-3*t-(2*t-1)*TaskApprox.delta(i);
        }

        public static double F2(double t, double x1, double x2)
        {
            return x1-x2+t*t-2;
        }
        public static double delta(int i){
            if (i == 2 || i == 4) return 1;
            else return eps;
        }
    }

    static class TaskReal
    {
        public static int  n=1000;

        public static double a=0, b=1, h;

        public static double[] t = new double[n + 1];
        public static double[] x1Real = new double[n+1];
        public static double[] x2Real = new double[n + 1];
        public static double[] uReal = new double[n + 1];

        public static void calc()
        {
            h = (b - a) / n;

            for (int i = 0; i <= n; i++) t[i] = i * h;

            for (int i = 0; i <= n; i++)
            {
                x1Real[i] = 2 * t[i] + 1;
                x2Real[i] = t[i] * t[i] - 1;
                uReal[i] = 2 * t[i] - 1;
            }
        }
    }
}
