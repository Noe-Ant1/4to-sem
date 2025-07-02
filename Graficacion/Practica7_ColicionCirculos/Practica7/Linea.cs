/*
 * Created by SharpDevelop.
 * User: Alumno
 * Date: 21/09/2022
 * Time: 11:58
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
	/// Description of Linea.
	/// </summary>
	public class Linea
	{
		Punto a,b;
		float Cr,Cg,Cb;
		double pendiente;
		int grosor;
		double longitud;
		
		
		public Linea()
		{
			Cr=Cg=Cb=1;
			a=b=new Punto();
		}
		
		public Linea(Punto A, Punto B)
		{
			this.a=new Punto(A.X,A.Y);
			this.b=new Punto(B.X,B.Y);
			grosor=1;
		}
		
		
		public void draw()
		{
			GL.LineWidth(grosor);
			GL.Color3(Cr,Cg,Cb);
			GL.Begin(PrimitiveType.Lines);
			GL.Vertex2(a.X,a.Y);
			GL.Vertex2(b.X,b.Y);
			GL.End();
		}
		
		public void draw(Punto A,Punto B)
		{
			GL.Color3(Cr,Cg,Cb);
			double minX,maxX,minY,maxY=0;
			GL.PointSize(1);
			if(A.X!=B.X)
			{
				double m=(A.Y-B.Y)/(A.X-B.X);
				if(A.X<B.X){
					minX=A.X;
					minY=A.Y;
					maxX=B.X;
					maxY=B.Y;
				}
				else{
					minX=B.X;
					minY=B.Y;
					maxX=A.X;
					maxY=A.Y;
				}
				GL.Begin(PrimitiveType.Points);
				for (float i = (float)minX; i <= maxX; i+=0.0001f) {//0.0000001	
					GL.Vertex2(i,(m*(i-minX))+minY);
				}
				GL.End();
			}else{
				if(A.Y<B.Y){
					minY=A.Y;
					maxY=B.Y;
				}
				else{
					minY=B.Y;
					maxY=A.Y;
				}
				GL.Begin(PrimitiveType.Points);
				for (float i = (float)minY; i <= maxY; i+=0.0001f) {//0.0000001	
					GL.Vertex2(A.X,i);
				}
				GL.End();
			}
		}
		
		public void Pendiente(Punto A,Punto B){
			this.pendiente=(B.Y-A.Y)/(B.X-A.X);
		}
		
		public void dibujarP(Punto A,Punto B)
		{   //GL.Color3(0,0,0);
			GL.PointSize(1);
			Pendiente(A,B);
			GL.Begin(PrimitiveType.Points);
			double pen = (B.Y-A.Y)/(B.X-A.X);
			for(double x=B.X; x < A.X; x+=0.0001)
			{
				GL.Vertex2(x,x*pen);
			}
			GL.End();			
		}
		
		public void setColor(float red, float green, float blue)
		{
			this.Cr=red;
			this.Cg=green;
			this.Cb=blue;
		}
		
		public int ancho
		{
			set{this.grosor=value;}
			get{return this.grosor;}
		}
		
		public void dda(Punto A, Punto B)
		{
			this.a=A;
			this.b=B;
			double mayor=0;
			double dx=A.X-B.X;
			double dy=A.Y-B.Y;
			
			mayor=(dx>dy)?dx:dy;
			
			dx=dx/mayor;	
			dy=dy/mayor;
			double x=A.X;
			double y=A.Y;
			//Console.WriteLine(dx+" "+dy);
			GL.PointSize(3);
			for (float i = 0; i < mayor; i+=1) {
				x=x+dx;
				y+=dy;
				GL.Begin(PrimitiveType.Points);	
				GL.Color3(0f,0f,0f);
				GL.Vertex2(Math.Ceiling(x),Math.Ceiling(y));
				GL.Color3(0.3f,0.3f,0.3f);
				GL.Vertex2(Math.Floor(x),Math.Floor(y));
				GL.End();
			}
		}
		
		public void ddaC(Punto A, Punto B)
		{
			this.a=A;
			this.b=B;
			double incX,incY,mayor=0;
			
			double dx=B.X-A.X;
			double dy=B.Y-A.Y;
			GL.PointSize(1);
			mayor=(dx>dy)?dx:dy;
			//Console.WriteLine("DX: "+dx);
			//Console.WriteLine("DY: "+dy);
			incX=dx/mayor;	
			incY=dy/mayor;
			double x=A.X;
			double y=A.Y;
			
			for(int i=0; i<=mayor;i++)
			{
				GL.Begin(PrimitiveType.Points);	
				GL.Color3((Cr-0.03),Cg-0.03,Cb-0.03);
				GL.Vertex2(Math.Ceiling(x),Math.Ceiling(y));
				GL.Color3(Cr,Cg,Cb);
				GL.Vertex2(Math.Floor(x),Math.Floor(y));
				GL.End();
				x=x+incX;
				y+=incY;
			}

		}
		
		public double calcularLongitud()
		{
			this.longitud=Math.Sqrt((a.X-b.X)*(a.X-b.X)+((a.Y-b.Y)*(a.Y-b.Y)));
			return(this.longitud);
		}

	}
}
