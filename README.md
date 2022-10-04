
<h1>Aerolineas San Francisco Heights</h1>

<h2> Sobre Mi </h2>
<p>Mi nombre es Lautaro Correa, tengo 24 años y empece programando a mis 16. Mi primer contacto con el mundo de la programacion fue en el secundario cuando conoci el mundo del desarrollo web. Luego de egresarme, consegui mi primer trabajo trainee junto a un grupo de programadores reducidos, creando juegos y aplicaciones AR/VR con c# en Unity3d. Fue entonces cuando me di cuenta que la programacion era mas que un hobby y que debia enfocarle mi vida profesional a ello.</br>
Hoy en dia sigo soñando con asentarme en una empresa seria, para poder crecer y construir mi perfil como desarrollador.</p>

<h2> Sobre la aerolinea </h2>

<p> El trabajo de la aerolinea me resulto exhaustivo, realmente tuve que dedicarle muchisimas horas para que funcionase de la forma que esperaba, asi como tambien lograr integrar todos los temas de forma correcta sin fallas. Aun asi el proceso de aprendizaje fue positivo, senti que mejore mi proyeccion a la hora de crear un trabajo desde 0, asi como tambien identifico mucho mejor  los problemas que aparecen en el proceso.</p>

<h2> Uso de la aplicacion </h2>
<ol>
<li><p> La aplicacion comienza con un LogIn, en el que si ingresamos los datos correspondientes a un vendedor ya cargado, nos permite acceder al sistema.</br>
Luego de acceder al sistema, nos encontraremos con una pantalla que nos muestra los Clientes que ya estan cargados en nuestro registro, y a la derecha una serie de botones que nos permitiran interactuar con la estructura del programa.</p></li>

<li><p>Seleccionando un Cliente y cliqueando en "Gestionar pasaje", accederemos al panel de ventas de la empresa. Donde podremos seleccionar un vuelo segun las opciones que nos ofrece, y cargar los datos correspondientes a las preferencias del pasajero.</p></li>

<li><p>Cliqueando en el boton "Historial de vuelos" podemos acceder a los registros historicos de la aerolinea, como la Recaudacion, los pasajeros que hay en cada vuelo, los pasajeros mas frecuentes ordenados por cantidad de vuelos, los destinos ordenados por facturacion, y el registro de aviones junto a sus horas de vuelo </p></li>

<li><p>"Agregar nuevo cliente" nos permite acceder al alta de un nuevo cliente. El mismo se vera reflejado en la lista de Clientes del menu principal como se menciono anteriormente</p></li>

<li><p>"Agregar vuelos" nos permite acceder a un formulario con la lista de aviones que existe en la aerolinea, y seleccionandolo, podremos sumarlo a un vuelo generado con los datos completados en el formulario</p></li>

</ol>
<h1>Diagrama</h1>

![Diagrama De Clases](/Diagrama.jpeg)

<h1>Justificacion tecnica</h1>

<h2>Clases y metodos estaticos</h2>

<p> La unica clase estatica creada en mi proyecto es la clase ValidadoraDeDatos, la cual se encarga de validar el rango de los DNI ingresados para las personas, asi como la validacion de strings alfanumericos para la asignacion de matriculas de los aviones. Esta clase, nos permite devolver valores de retorno en sus metodos, sin depender de las instancias de nuestros objetos</p>
<p> Aun asi, continuamos con el uso de metodos estaticos, para el agregado de objetos en listas, y calculos pertinentes a la administracion de la aerolinea. Estos metodos pueden encontrarse en la clase "Administracion". La intencion de la creacion de esta clase es gestionar la responsabilidad de la aerolinea y poder agrupar todos los metodos de gestion en un mismo espacio.</p>
<p> La clase Vuelo es la unica clase que posee un constructor estatico para inicializar el identificador de los vuelos.</p>

<h2>POO: Abstraccion, Herencia, Encapsulamiento, y Polimorfismo </h2>

<h3>Abstraccion y Herencia</h3>
<p> El programa posee una clase abstracta llamada "Persona", y dos clases heredadas de la misma llamadas "Vendedor" y "Cliente".</p>
<p>Estos dos ultimos fueron creados con la intencion de separar los atributos y comportamientos que diferencian a los vendedores de los clientes en si, aunque ambos sean considerados persona.</p>
<p>De no haber creado estas dos ultimas clases mencionadas, no habria sido posible crear un sistema seguro en el que ciertas personas puedan loguearse (vendedores) para gestionar todas las compras que los clientes de la aerolinea deseen realizar, ya que lo que diferencia una de otra, son los atributos "Password" y "Usuario" necesarios para la administracion del LogIn al comienzo del programa. Aun asi y todo, siguen heredando los miembros de persona para registrar la informacion base como su nombre, apellido, dni , etc</p>

<h3> Encapsulamiento </h3>
<p>Se generaron propiedades del tipo SET y GET para el facil acceso de cada uno de los atributos rpivados que poseen las clases anteriormente mencionadas, asi como tambien la clase Vuelo y Avion.</p>
<p>Cada una de las clases posee sus atributos privados, para poder mejorar aun mas la seguridad de la informacion, siendo posible acceder a los datos en tiempo de ejecucion mediante las propiedades publicas</p>
<p>En algunos casos, las propiedades son accedidas por metodos externos, aunque la gran mayoria de estas son modificadas por las propiedades PRIVADAS SET desde los constructores. Para asi impedir que estos datos se vean vulnerabilizados por fuera del flujo del programa</p>

<h2>Sobrecargas</h2>
<p>El metodo por defecto ToString() devuelve el literal del tipo de objeto al cual estemos accediendo</p>
<p>Aprovechando que algunas funcionalidades acceden al ToString() de los objetos, y sabiendo que necesitamos hacer el muestreo de algunas propiedades de nuestra construccion del objeto, se procedio a sobreescribir este metodo en todas las clases creadas con un formateo especial en cada una para, por ejemplo, mostrar la lista de Clientes existentes, asi como cualquier tipo de informacion descriptiva de los datos almacenados.</p>
</br>
<p>El metodo por defecto Equals() nos devuelve un booleano que define si un objeto es literalmente el objeto que le pasemos por parametro. obj.Equals(obj)</p>
<p>En mi caso, se sobreescribio este metodo para saber si los identificadores correspondientes a cada clase, coincidian. Por ejemplo, en la clase Cliente, se sobreescribio el Equals para saber si el DNI del cliente coincidia con el dni del objeto invocado</p>
</br>
<p>El metodo por defecto GetHashCode() nos devuelve un codigo hash (id unico) del objeto que estemos invocando</p>
<p>En mi caso, este metodo fue utilizado para comparar los codigos hash de los identificadores de los vuelos, para asi evitar que el match de los identificadores literales (int == int) produzcan un problema en caso de duplicados</p>

<h2>Colecciones</h2>
<p>El unico uso de las colecciones dentro del programa, se encuentra en la seccion de registro. Ya que para la organizacion de los destinos segun su recaudacion, se decidio utilizar un diccionario ya que es mas sencillo ubicar cada destino junto a su valor con el uso del par <key,value>. Donde la KEY es el Enum, y el value el monto recaudado para el mismo</p>
  
<h2> Opinion del programa </h2>
<p>Como contra, considero que el programa podria ser aun mas robusto, ya que me hubiera gustado poder hacer un muestreo mas claro de la informacion en pantalla, como sucede en caso de los listbox que muestran los objetos poco claros a la vista, siendo que el uso de DataGrid podria haber facilitado mucho el flujo del programa y el entendimiento del mismo.</p>
<p>Como "pro", opino que el programa cuenta con un buen abanico de manejo de errores. Creo que se logro una buena experiencia de usuario siendo un formulario aparentemente "sencillo" en cuanto a diseño. Aun asi, me hubiera gustado poder aplicar el uso de formularios heredados al programa para agilizar el uso de la memoria.</p>
<h3>Valor agregado</h3>
<p>Como valor agregado, se implementarion bloques try catch para mejor manejo de los erroes del programa, asi como tambien la implementacion del alta de aviones en el sistema. En su momento me plantee agregar el uso de distintos perfiles como administrador/vendedor/propietario pero debido a la falta de tiempo me veo limitado a agregar solo esta funcionalidad.</p>
