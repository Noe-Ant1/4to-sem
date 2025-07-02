class Nodoa{
  public int info;
  public Nodoa izq;
  public Nodoa der;   

  public Nodoa(int dato){
	info = dato;
	izq = null;
	der = null;
  }
}

public class arbolbin1{
  private Nodoa raiz1;
  int c;
  
 public arbolbin1(){
    raiz1 = null;
    c=0;
 }
  
 public void insertar(int valor){
    Nodoa nuevonodo = new Nodoa(valor);
    Nodoa actual = raiz1;
    Nodoa anterior = null;
    if(raiz1 == null) raiz1=nuevonodo;
    else{
    	 while (actual!=null ){
    	 	anterior=actual;
    	 	if (valor>actual.info) 
    	 		actual=actual.der;
            else if (valor<actual.info) 
            	actual = actual.izq;
            	else return ;
         }
       if (valor>anterior.info) anterior.der=nuevonodo;
          else anterior.izq=nuevonodo;    	
       }
 } 
 	
 public void preorden(Nodoa aux){
	if (aux!=null){
  	 System.out.print(aux.info+"  ");
  	 preorden(aux.izq);
     preorden(aux.der);
    }
 }
    
 public void inorden(Nodoa aux){
  	if (aux!=null){ 
  	 inorden(aux.izq);
     System.out.print(aux.info+"  ");
     inorden(aux.der);
    }
  }
    
 public void postorden(Nodoa aux){
	if (aux!=null){
  	 postorden(aux.izq);
     postorden(aux.der);
     System.out.print(aux.info+"  ");
    }
  }
    
 public Nodoa Obten_raiz(){
  	return raiz1;
 }

 public void altura (Nodoa aux){
	int altizq, altder, c=0;
	if(aux==null){
		return -1;
	}else{
		altizq = altura(aux.izq);
		altder = altura(aux.der);
		c++;
		
		if(){
		}
	}
 }
 
 public void front(Nodoa aux){
	 
 }
 
 public void zurdo(Nodoa aux ){
	 
 }
  
 public static void main(String []args){
     int x;
     arbolbin1 b = new arbolbin1();
     b.insertar(10);
     b.insertar(20);
     b.insertar(5);
     b.insertar(2);
     b.insertar(15);
     b.insertar(7);
     b.insertar(12);
     b.insertar(17);
     System.out.println("Recorrido en PreOrden");
     b.preorden(b.Obten_raiz());
     System.out.println();
     System.out.println("Recorrido en InOrden");
     b.inorden(b.Obten_raiz());
     System.out.println();
     System.out.println("Recorrido en PostOrden");
     b.postorden(b.Obten_raiz());  
 }
}
