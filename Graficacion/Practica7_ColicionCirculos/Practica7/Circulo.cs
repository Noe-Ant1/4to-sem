/*
 * Created by SharpDevelop.
 * User: Alumno
 * Date: 21/09/2022
 * Time: 11:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using OpenTK;
//using OPenTK.Grapghics;
using OpenTK.Graphics.OpenGL;

namespace Practica7
{
	/// <summary>
	/// Description of Circulo.
	/// </summary>
	public class Circulo
	{
		
		private double radio;
		double r,g,b;
		Punto[] poligono;
		Punto centro;
		double anguloInicial, anguloFinal;
		PrimitiveType tipo;
		
		
		public Circulo()
		{
			this.radio=anguloInicial=0;
			this.centro=new Punto(0,0);
			anguloFinal=Math.PI*2;
			tipo=PrimitiveType.LineLoop;
		}
		
		public double Radio
		{
			set {this.radio=value-0.2;}
			get {return this.radio;}
		}
		
		public Punto Centro
		{
			set{this.centro=value;}
			get{return this.centro;}
		}
		
		public void draw()
		{

			GL.Color3(r,g,b);
			GL.Begin(tipo);
			
			for(double i=(0); i<Math.PI*2; i+=0.01)
			{
				GL.Vertex2(centro.X+r*Math.Cos(i),centro.Y+r*Math.Sin(i));
			}
			GL.End();
		}
		
		public void draw(Punto a, double r)
		{
			this.centro=a;
			this.radio=r-0.02;
			GL.Color3(1,1,1);
			GL.Begin(PrimitiveType.Polygon);
			for(double t=anguloInicial;t<anguloFinal;t+=0.1)
			{
				GL.Vertex2(a.X+r*Math.Cos(t),a.Y+r*Math.Sin(t));
			}
			GL.End();
		}
		
		public void arco(double angIn, double angFin) //ang en grados
		{
			this.anguloInicial=(angIn/180)*Math.PI;
			this.anguloFinal=(angFin/180)*Math.PI;
		}
		
		
		public void drawR(double radio) //DIBUJAR UNA CIRCUNFERENCIA DE RADIO r CON TRIGONOMETRICAS
		{	
			GL.Color3(1,0,0);
			GL.PointSize(1);
			GL.Begin(PrimitiveType.Points);
			double perimetro=Math.PI*2*radio;
			for(double i=(0); i<perimetro; i+=0.0001)
			{
				GL.Vertex2(radio*Math.Cos(i),radio*Math.Sin(i));
				GL.Vertex2(radio*Math.Cos(i),-radio*Math.Sin(i)); //??
			}
			GL.End();
		}
		
		public void setColor(double rojo, double verde, double blue)
		{
			this.r=rojo;
			this.g=verde;
			this.b=blue;
		}
		
		public void dibujarPoligono(int n)
		{
			this.poligono=new Punto[n];
			GL.PointSize(5); //POINT SIZE SE DEBE COLOCAR FUERA DE BEGIN PARA QUE FUNCIONE
			GL.Begin(PrimitiveType.Points);
			for(double i=0; i<n; i++)
			{
				double aux=((2*Math.PI)*(i/n));
				//Console.WriteLine(radio*Math.Sin(aux));
				GL.Vertex2(radio*Math.Sin(aux),radio*Math.Cos(aux));
				poligono[(int)i]=new Punto(radio*Math.Sin(aux),radio*Math.Cos(aux));
			}
			GL.End();
			
			GL.PointSize(2);
			GL.Begin(PrimitiveType.LineLoop);
			for(int i=0; i<n; i++)
			{
				Punto A=poligono[i];
				GL.Vertex2(A.X,A.Y);
			}
			GL.End();	
		}
		
	}
}
