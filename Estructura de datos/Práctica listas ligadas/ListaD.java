public class ListaD {
    NodoD primero;
    NodoD ultimo;

    public ListaD(){
        primero = null;
        ultimo = null;
    }

    public void insertar(int x){
        System.out.println(" ");
        NodoD temp = new NodoD(x);
        if(primero == null){
            primero = temp;
            ultimo = temp;
            ultimo.sig = primero;
            primero.ant = ultimo;
        }else{
            NodoD aux = primero;
            int vuelta = 0;
            while(aux.info < x && vuelta != 1){
                aux = aux.sig;
                if(aux==primero) vuelta=1;
            }
            temp.sig = aux;
            temp.ant = aux.ant;
            aux.ant.sig = temp;
            aux.ant = temp;
            if(temp.info<=primero.info){
                primero = temp;
            }else if(temp.info > ultimo.info){
                ultimo = temp;
            }
        }
        System.out.println("Dato insertado: "+x+" ");
    }

    public void recorrerD(){
        System.out.println(" ");
        System.out.println("Recorrer por la derecha");
        NodoD aux = primero; int vuelta = 0;
        while(vuelta != 1){
            System.out.println("["+aux.info+"]");
            aux = aux.sig;
            if(aux==ultimo.sig) vuelta=1;
        }
    }

    public void recorrerI(){
        System.out.println("Recorrer a la Izquierda");
        NodoD aux = ultimo; int vuelta = 0;
        while(vuelta != 1){
            System.out.println("["+aux.info+"]");
            aux = aux.ant;
            if(aux==primero.ant){
                vuelta=1;
			}
        }
    }

    public void eliminar(int x){
        System.out.println(" ");
        NodoD aux = primero;
        if(primero == null){
            System.out.println("No hay elementos");
        }else{
            int vuelta = 0;
            while(aux.info != x && vuelta != 1){
                aux = aux.sig;
                if(aux==primero) vuelta=1;
            }
            if(aux.info != x){
                System.out.println("No existe el dato");
            }else{
                if(aux == primero){
                    primero = primero.sig;
                }else if(aux == ultimo){
                    ultimo = ultimo.ant;
                }
                aux.ant.sig = aux.sig;
                aux.sig.ant = aux.ant;
                aux.sig = null;
                aux.ant = null;
                System.out.println("Ha sido eleminado ["+x+"]");
            }
        }
	}
	public void separa(int x){
		ListaD menores=new ListaD();
		ListaD mayores=new ListaD();
		
		NodoD aux = primero;
		while (aux!=null){
			if(aux.info<x){
				menores.insertar(aux.info);
			}else{
				mayores.insertar(aux.info);
			}
			aux = aux.sig;
		}
		System.out.println("Lista 1.- Valores menores a: "+x);
		menores.recorrerD();
		menores.recorrerI();
		System.out.println("Lista 1.- Valores mayores a: "+x);
		mayores.recorrerD();
		mayores.recorrerI();
	}
}
