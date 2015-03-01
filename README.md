
![dPeluChe Studios Logo](http://dpeluchestudios.com/Press/dPeluCheLogo_Wide.jpg)

# Unity_GUIPointsSystem

## Languages - Idiomas

- <a href="#DocuESP">Documentación en Español</a>
- <a href="#DocuENG">Documentation in English</a>

________



<a class="anchor" href="#DocuENG" aria-hidden="true"></a>
##Documentation

Using GUIpointsSystem.cs [Codigo](https://github.com/dPeluChe/Unity_GUIPointsSystem/tree/master/_Code) you can create any number using one sprite which contains (0-9 numbers). The script creates gameObjects and Sprites helping the conservation of size, format and space for the numbers in any platform that you will export the project. 

**Sprite Format**:
![Image Example](http://dpeluchestudios.com/Github/Unity_GUIPointsSystem/Sizes.PNG)
**Result**:
![Result Example](http://dpeluchestudios.com/Github/Unity_GUIPointsSystem/Example.PNG)


##Recomendations
We recommend that the sprite with the digits must have  the same size for example (w: 30px h: 30px). This help the automatically creation conserving the separation space. And looks really nice :P


![Image Example](http://dpeluchestudios.com/Github/Unity_GUIPointsSystem/Sizes.PNG)

You can download our PSD example file: [Archivo]( https://github.com/dPeluChe/Unity_GUIPointsSystem/tree/master/_Imgs)


##Initialiation
Only need add the script to a gameObject and assign the sprites in the public array with the same order of creation.

![Init Example](http://dpeluchestudios.com/Github/Unity_GUIPointsSystem/InitExample.PNG)

In the **Awake** method  is the initial value for the script under the _txtMain variable. If in runtime need change the numbers value you can call these public functions: 

- **changePointsWithIntValue(int Points)**
- **changePointsWithStringValue(string “Points”)**


###Contact

Follow us in Facebook (http://facebook.com/dPeluCheStudios).

Check our WebSite (http://dPeluCheStudios.com).

And download our games :D 

Keep Playing ;)

dPeluChe Studios


________


<a class="anchor" href="#DocuESP" aria-hidden="true"></a>
##Documentación
La clase GUIpointsSystem.cs [Codigo](https://github.com/dPeluChe/Unity_GUIPointsSystem/tree/master/_Code) tiene el propósito de crear cualquier numero utilizando un sprite el cual contiene los dígitos del 0 al 9 mediante gameObjects y Sprites, con esto se busca que los números utilizados tengan el mismo tamaño, espacio y formato de la imagen con los dígitos sin importar las plataformas que se dese exportar. 



**Formato del Sprite**:
![Image Example](http://dpeluchestudios.com/Github/Unity_GUIPointsSystem/Sizes.PNG)


**Resultado utilizando GUIpointsSystem.cs**:
![Result Example](http://dpeluchestudios.com/Github/Unity_GUIPointsSystem/Example.PNG)








##Recomendaciones
Se recomienda que todos los sprites tengan el mismo tamaño para que los dígitos al ser creados se vean uniformes y la separación entre ellos sea la adecuada. 
![Image Example](http://dpeluchestudios.com/Github/Unity_GUIPointsSystem/Sizes.PNG)

Puedes utilizar como base nuestro archivo PSD: [Archivo]( https://github.com/dPeluChe/Unity_GUIPointsSystem/tree/master/_Imgs)



##Inicialización
Al poner el script en un gameobject se le deben asignar los sprites creados en el arreglo público AllGuiNumbers situando cada digito en la posición de elementos indicada (0 al 9).

![Init Example](http://dpeluchestudios.com/Github/Unity_GUIPointsSystem/InitExample.PNG)


En el metodo **void Awake()** se inicializa la variable * _txtMain* que se utiliza para crear los sprites dependiendo los digitos utilizados. 

Durante el runtime se puede cambiar este valor utilizando las funciones publicas: 

- **changePointsWithIntValue(int Puntos)**
- **changePointsWithStringValue(string “Puntos”)**

Dependiendo el formato en el que se tengan los dígitos a mostrar.


____

###Contacto

Sígannos en Facebook (http://facebook.com/dPeluCheStudios).

Visiten nuestro sitio web (http://dPeluCheStudios.com).

Y descarguen nuestros juegos :D 

Keep Playing ;)

dPeluChe Studios









