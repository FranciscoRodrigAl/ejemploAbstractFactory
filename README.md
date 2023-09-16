# Ejemplo AbstractFactory

## Resumen

Este repositorio muestra un pequeño ejemplo del patrón de diseño **Abstract Factory**  
Se utiliza una **interfaz inicial** *IMarioWorldFactory* que define dos métodos para crear objetos (un método por cada tipo de objeto).  
Cada método pide devolver una instancia de un objeto, y el objeto a crear se define primero en una interfaz.  
De este modo, como se desea crear dos tipos de objetos se definen dos interfaces *ILadrillo* y *IBloqueInterrogacion*.  
¿Que contiene la interfaz de cada tipo de objeto?
Algún metodo relacionado con sus caracteríticas, en el ejemplo solo son funciones que retornan un string a modo de mensaje.

Luego de definir la interfaz de la fábrica y las interfaces de los productos a crear, se deben implementar todas esas interfaces en clases **concretas**
Estas clases concretas son:

1. Clases Fábrica que implementan la interfaz *IMarioWorlFactory*.
2. Clases Producto que implementan cada una de las interfaces para cada tipo de objeto, es decir, *ILadrillo* y *IBloqueInterrogacion*.

Las clases concretas de fábricas se definen cada vez que necesitamos una fabrica que genere toda una gama o *variante* de productos.  
En el ejemplo se genera una clase de FabricaMala que implementa la interfaz *IMarioWorldFactory* y debido a esto la clase concreta esta obligada a definir la generación de productos Ladrillo y BloqueInterrogación.
Sin embargo al tratarse de una fabrica concreta debe crear variantes concretas de cada producto, debido a esto se deben utilizar clases concretas de cada producto, que estén asociadas a una variante del producto.
Por ello la clase concreta FabricaMala devuelve en cada método nuevas instancias de productos "malos" siendo estos LadrilloBomba y BloqueInterrogacionTrampa, que a su vez son implementaciones de las interfaces *ILadrillo* e *IBloqueInterrogacion* respectivamente.

De la misma forma se crea la clase concreta FabricaPremios, que tiene metodos para devolver productos de la clase LadrilloMoneda y BloqueInterrogacionEstrella, tambien estos son implementaciones de *Iladrillo* e *IBloqueInterrogacion*.

Finalmente, y ya terminada la implementación del patrón de diseño, solo de forma opcional, se genera una clase cliente que hará peticiones de productos a instancias de las clases fabrica concretas, haciendo uso de los métodos de creacion que disponen.
se puede probar que cada producto es de una clase concreta utilizando el metodo del que dispone el producto para indicar su tipo en el mensaje que devuelve, es decir, el metodo **contieneItem** para los ladrillos y **nombreItemObtenido** para los BloqueInterrogacion.
