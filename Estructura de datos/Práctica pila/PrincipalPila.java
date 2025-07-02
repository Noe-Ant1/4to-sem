import java.util.Scanner;

public class PrincipalPila{
	
		static Scanner leer = new Scanner(System.in);
	
		static int tamanio = 0;
		static int dato = 0, opc = 0;
		static int exit = 0;
	
	public static void main(String[] args) {
		
		System.out.println("Bienvenido.");
		System.out.println("Digite el rango de la pila.");
		
		tamanio = leer.nextInt();
		 
		Pila a = new Pila(tamanio);
		Pila b = new Pila(tamanio);
		Pila c = new Pila(tamanio);
		
		do {
			System.out.println(
				"\n1.- Crear pila A." +
				"\n2.- Crear pila B."+ 
				"\n3.- Sumar pilas (A + B)" +
				"\n4.- Salir.");
			System.out.print("R: ");
			exit = leer.nextInt();
			System.out.println("\n");
			
			switch (exit) {
				case 1:
				System.out.println("Inserte datos pila a.");
				display(a);
				System.out.println("");
				break;
				case 2:
				System.out.println("Inserte datos pila b.");
				display(b);
				System.out.println("");
				break;
				case 3:
				System.out.println("Suma de pilas.");
				c.suma(a, b);
				c.mostrar();
				break;
				
			}
			
		}while (exit !=3);
	} 
		public static void display(Pila a) {
			
			do {
			System.out.println(
				"\nQue desea realizar?." +
				"\n1.- Ingresar dato." + 
				"\n2.- Eliminar dato." +
				"\n3.- Saber si la pila esta vacia." +
				"\n4.- Saber si la pila esta llena." +
				"\n5.- Mostrar pila" +
				"\n6.- Tamanio de pila." +
				"\n7.- Salir.");
			System.out.print("R: ");
			opc = leer.nextInt();
			System.out.println("\n");
			
			switch (opc) {
				case 1:
				System.out.println("Inserte datos.");
				a.insertar(dato = leer.nextInt());
				System.out.println("Dato registrado.");
				System.out.println("");
				break;
				case 2:
				a.eliminar();
				System.out.println("");
				break;
				case 3:
				System.out.println(a.vacio());
				System.out.println("");
				break;
				case 4:
				System.out.println(a.lleno());
				System.out.println("");
				break;
				case 5:
				a.mostrar();
				System.out.println("");
				break;
				case 6:
				System.out.println(a.tamanio());
				break;
				
			}
		}while (opc !=7);
	}
}
