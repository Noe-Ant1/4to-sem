/*
 * Created by SharpDevelop.
 * User: Alumno
 * Date: 21/09/2022
 * Time: 11:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
namespace Practica7
{
	/// <summary>
	/// Description of Punto.
	/// </summary>
	public class Punto
	{
		private double x,y;
		private float r,g,b;
		
		public Punto()
		{
			x=y=0;
			r=g=b=0;
		}
		
		public Punto(double X, double Y)
		{
			x=X;
			y=Y;
		}
	
		public double X
		{
			set {x=value;}
			get {return this.x;}
		}
		
		public double Y
		{
			set {y=value;}
			get {return this.y;}
		}
		
		public void set(double X,double Y)
		{
			x=X;
			y=Y;
		}
		
		public void Draw()
		{	
			GL.PointSize(5);
			GL.Color3(r,g,b);
			GL.Begin(PrimitiveType.Points);
			GL.Vertex2(this.x,this.y);
			GL.End();
		}
		
		public void PuntoRGB(float red,float green, float blue)
		{
			this.r=red;
			this.g=green;
			this.b=blue;
		}
	}
}
