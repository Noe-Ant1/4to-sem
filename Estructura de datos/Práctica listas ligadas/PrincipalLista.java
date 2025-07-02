import java.util.Scanner;

public class PrincipalLista{

    public static void main(String[] args) {
        ListaD L = new ListaD();

        L.insertar(6);
        L.insertar(4);
        L.insertar(8);
        L.insertar(5);
        L.insertar(1);

        L.recorrerD();
        L.recorrerI();

        L.eliminar(4);

        L.recorrerD();
        L.recorrerI();
        
        L.separa(8);
        L.recorrerD();
        L.recorrerI();
    }
 }
