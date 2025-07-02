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
using OpenTK.Graphics.OpenGL;

namespace Practica7
{
	/// <summary>
	/// Description of Poligono.
	/// </summary>
	public class Poligono
	{
		double lados;
		double anguloInicial,anguloFinal,r,g,b;
		//ColorPointerType ciki;
		PrimitiveType tipo;

		
		public Poligono()
		{			
			anguloInicial=0;
			anguloFinal=Math.PI*2;
			tipo=PrimitiveType.LineLoop;
			lados=0.1;
			r=g=b=1;
		}
		
		public void draw(double x, double y, double r) //(CENTRO EN X,Y, Y TAMAÑO)
		{
			GL.Color3(r,g,b);
			GL.LineWidth(4);
			GL.Begin(tipo);
			for(double t=anguloInicial;t<anguloFinal+anguloInicial;t+=lados)
			{
				GL.Vertex2(x+r*Math.Cos(t),y+r*Math.Sin(t));
			}
			GL.End();
		}
		
		public void fullDraw(double x, double y, double r)
		{
			for(double i=r;i>=0;i-=1)
			{
				this.draw(x,y,i);
			}
			GL.Color3(r,g,b);
			GL.PointSize(3);
			GL.Begin(PrimitiveType.Points);
			GL.Vertex2(x,y);
			GL.End();
		}
		
		public void set(double angIn, int l) //ang en grados
		{
			this.anguloInicial=(angIn/180)*Math.PI;
			lados=(Math.PI*2)/l;
		}
		
		public void color(double rojo, double verde, double blue){
			this.r=rojo;
			this.g=verde;
			this.b=blue;
		}
	}
}
