# T�tulo: Un Truquito

## Resumen

La aplicaci�n es un simulador del juego "Truco" online, donde se ingresa con un usuario �nico y una contrase�a, en caso de no tener un usuario se pueden registrar.
Una vez adentro del menu principal del juego el usuario podr�:

* visualizar el top 5 de los mejores jugadores, un datagridview de las partidas que estan comenzando en ese momento y tiene 3 segundos para ingresar a la partida o esta
 comenzar� y no podr� acceder a verla, al clickearlas se habilitar� el bot�n de ver partida en donde podr� presenciar una partida entre dos jugadores. 

* entrar a sus estad�sticas donde podr� ver sus partidas ganadas (junto con la fecha de las partidas y el jugador que haya perdido), como 
 tambi�n podr� ver la cantidad de partidas ganadas, perdidas, como un dato extra podr� visualizar la cantidad de anchos de espada que obtuvo cada vez que haya jugado y 
 la cantidad de veces que haya cantado "falta envido".

* visualizar las reglas del juego, mediante un bot�n que al presionarlo se abre un panel con las reglas y al volver a presionarlo el panel se cerrar�


## Diagrama de clases



## Justificaci�n t�cnica

### SQL

Se utiliza la base de datos para la persistencia de datos de los Usuarios y de las Partidas. De ese modo durante el programa se podr� obtener la informaci�n, agregar
nuevos Usuarios y/o Partidas y modificar los ya existentes.

### Excepciones

Se utilizan excepciones en varias partes del c�digo en donde podr�a ocurrir un error en tiempo de ejecuci�n o en errores del usuario como por ejemplo en el login donde 
se lanza una excepci�n controlada en caso de que el usuario o la contrase�a sean incorrectos o cuando el usuario se registra, si el nombre de usuario que ingresa ya existe
entonces se lanzar� una excepci�n  para informar mediante un label que el nombre ya existe.

### Unit Testing

Se hace una clase de Unit Testing por cada clase de Entidades.Modelo, comprobando que funcionen tanto por �xito como por fallo e incluso dependiendo el m�todo tambi�n
se realizan pruebas unitarias de distintas variantes de �xito como de fallo.

### Generics

Se utiliza generics dentro de la calse Serializador con el funcionamiento de poder serializar y deserializar cualquier tipo de objeto.

### Serializaci�n

Se utiliza la serializaci�n para deserializar el mazo de cartas con el que se jugar�n las partidas. 

### Escritura Archivos

Se utiliza la escritura de archivos para guardar el RichTextBox cada vez que termina una partida. Se le consulta al usuario si desea guardarlo y en caso de que acepte
se guardar� un archivo de texto en el escriturio dentro de una carpeta llamada "Partida".

### Interfaces

Se utilizan las interfaces para desarrollar el modelo MVP con el prop�sito de dejar la l�gica en las entidades y quitarla del formulario. De ese modo todas las clases 
se encuentran protegidas dentro de la biblioteca de clases y los presentadores mediante las interfaces son quienes se encargan de ser "intermediaros" entre la vista y el
modelo.

### Delegados

Se utilizan dentro del presentador PresentadorSala para activa los eventos de la partida y suscribirle los m�todos propios de la finalizaci�n de la vuelta para un 
delegado y para el otro los propios de la finalizaci�n de la partida.

### Task

Se utiliza task para hacer posible la visualizaci�n de las partidas y que el juego funcione en distintas ventanas. 

### Eventos

Se utilizan eventos dentro de la clase Partida para accionar los m�todos del mazo (Barajar, Repartir) y otro para la finalizaci�n de la partida que asigna puntos y 
reestablecer los valores de cada jugador
 
