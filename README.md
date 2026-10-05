
# Practica2_MovimientoEnUnity

## Introducción

En esta práctica se han realizado los ejercicios 5 al 13 sobre el movimiento de objetos en Unity mediante scripts de C#. 

Se han utilizado vectores, velocidades y controles de teclado para desplazar objetos, además de `Time.deltaTime` para conseguir un movimiento uniforme. También se ha trabajado el seguimiento y la orientación de un objeto hacia otro, así como el movimiento automático utilizando la dirección hacia delante del objeto. 

Entre las estructuras y componentes más utilizados se encuentran `Transform`, `Rotate`, `Translate`, `Vector3` e `Input`, así como funciones como `LookAt` y `GetAxis`.

### Ejercicio 5

En este ejercicio se prepara un desplazamiento mediante un vector `Vector3`. Al pulsar la barra espaciadora, el objeto cambia de posición según los valores en el Inspector.

También comentar que se usa `GetKeyDown` para que el movimiento solo se produzca una vez al pulsar la tecla.

<img width="2878" height="1584" alt="Grabación 2026-10-04 182512 (1)" src="https://github.com/user-attachments/assets/1d06f077-a675-4889-b699-630b95ed85f4" />

### Ejercicio 6

Aquí se comprueba cómo interviene la velocidad en el movimiento del objeto. Cada vez que se pulsa una tecla de dirección, se calcula el desplazamiento y se muestra el resultado en la consola.

También comentar el uso de `GetAxisRaw`para que de un valor fijo/entero (-1, 0 o 1) en lugar de un valor intermedio/con decimales.

<img width="2878" height="1574" alt="VideoEjercicio6" src="https://github.com/user-attachments/assets/f53efa20-5965-4af5-8832-256a6fbbd65e" />

### Ejercicio 7

En este ejercicio se personaliza el sistema de entrada de Unity para añadir una nueva acción. En concreto, se asigna la tecla H a la función de disparo para ver cómo se pueden configurar los controles.

<img width="2876" height="1642" alt="VideoEjercicio7" src="https://github.com/user-attachments/assets/4f0ddc4d-dada-4bc6-9495-d437bdfbc1ad" />

### Ejercicio 8

En este caso, el cubo comienza a moverse de forma continua siguiendo una dirección concreta. Tanto la dirección como la velocidad se pueden cambiar desde el Inspector. Además, se hace uso de `Time.deltaTime` ya que sino el movimiento sería demasiado rápido y no se apreciaría correctamente.

<img width="2868" height="1572" alt="VideoEjercicio8_base" src="https://github.com/user-attachments/assets/efced4e5-82e1-47aa-a3c6-26e5fde92e90" />

#### Apartado 8a

Al duplicar las coordenadas del vector de dirección, se aprecia que el cubo avanza más rápido, ya que la magnitud del vector es mayor. La dirección se mantiene, pero aumenta la distancia recorrida en cada frame.

<img width="2872" height="1580" alt="VideoEjercicio8_a" src="https://github.com/user-attachments/assets/c4e9f67a-54d9-4e9e-830a-3c5bd5b12091" />

#### Apartado 8b

Al duplicar la velocidad y mantener la misma dirección, se aprecia que el cubo recorre el mismo camino, pero lo hace en menos tiempo.

<img width="2876" height="1574" alt="VideoEjercicio8_b" src="https://github.com/user-attachments/assets/38baa94c-7708-4c31-9aa0-19b8cbcaec4c" />

El efecto tanto de duplicar el vector de movimiento como de duplicar la velocidad es el mismo, ya que ambos aumentan la distancia recorrida en cada frame. Sin embargo, la forma correcta de hacerlo es mediante la variable `velocidad`, ya que sino pueden fallar otros cálculos que dependan de la magnitud del vector de dirección.

#### Apartado 8c

Al utilizar una velocidad menor que uno, se aprecia que el cubo continúa avanzando en la dirección indicada, pero se desplaza más lentamente y recorre una menor distancia.

<img width="2876" height="1582" alt="VideoEjercicio8_c" src="https://github.com/user-attachments/assets/9262c556-1acb-4b8c-9faa-3a4f5f5760df" />

#### Apartado 8d

Al colocar el cubo en una posición con una altura mayor que cero, se aprecia que el movimiento parte desde ese nuevo punto, manteniendo la misma dirección. 

<img width="2878" height="1574" alt="VideoEjercicio8_d" src="https://github.com/user-attachments/assets/17de4050-4f82-42b0-b613-0dc415ed2ebc" />

#### Apartado 8e

Al intercambiar el sistema de referencia local y el mundial,no se aprecian cambios. Solo se apreciaría si el cubo estubiera girado. En este caso, como el cubo no está rotado, el movimiento es el mismo en ambos sistemas de referencia. 

En el caso de que el cubo estuviera rotado, para que el movimiento fuera el esperado habría que utilizar el sistema de referencia mundial, ya que el local estaría orientado de forma diferente.

<img width="2864" height="1576" alt="VideoEjercicio8_e" src="https://github.com/user-attachments/assets/94699438-77a2-4a38-b990-a5ddf279be8d" />

### Ejercicio 9

En este ejercicio se añaden controles directos para manejar los objetos de la escena. El cubo se mueve con las flechas y la esfera con las teclas W, A, S y D.

Asi pues, cabe destacar que al obtener el valor de `Input.GetAxis` se obtiene un valor entre -1 y 1, que sirve tanto para el movimiento con las flechas como para el movimiento con las teclas W, A, S y D.

<img width="2872" height="1580" alt="VideoEjercicio9" src="https://github.com/user-attachments/assets/8f508a19-7563-450a-a7d7-e48f17e73543" />

### Ejercicio 10

Se mejora el movimiento del ejercicio anterior utilizando `Time.deltaTime`. Gracias a ello, el objeto mantiene una velocidad más estable aunque se cambie de ordenador o este tenga una potencia diferente. 

<img width="2872" height="1578" alt="VideoEjercicio10" src="https://github.com/user-attachments/assets/b984b9bc-5d61-447e-aec3-cb8c3bc7ed58" />

### Ejercicio 11

En este punto el cubo deja de moverse únicamente con el teclado y comienza a seguir a la esfera. Para que no acelere cuando está más lejos, se normaliza el vector que marca la dirección hacia el objetivo. Además de esto, se utiliza `Time.deltaTime` para mantener una velocidad constante.

<img width="2870" height="1578" alt="VideoEjercicio11" src="https://github.com/user-attachments/assets/28f59ee5-172b-4e9e-a6ac-5b71f56a4069" />

### Ejercicio 12

Ahora el cubo no solo se desplaza hacia la esfera, sino que también gira para mirarla. Para conseguirlo se utiliza `LookAt`, haciendo que su orientación acompañe en todo momento a la dirección del movimiento.Además, se hace que el movimiento sea segun los ejes globales ya que como el cubo gira para mirar a la esfera, su eje local cambia y el movimiento no sería el esperado.

<img width="2868" height="1578" alt="VideoEjercicio12" src="https://github.com/user-attachments/assets/13041155-4bc2-48e2-9216-d9ffa949ded6" />

### Ejercicio 13

En el último ejercicio se crea un movimiento automático: el objeto avanza continuamente hacia delante gracias al `transform.forward` y con el uso del `Rotate` se hace que giro sobre el eje Y. Esto perrmite cambiar el "frente" del objeto y, por tanto, la dirección en la que se mueve. Como elemneto adicional, se mantiene el cubo siguiendo a la esfera.

<img width="2878" height="1580" alt="VideoEjercicio13" src="https://github.com/user-attachments/assets/2e0f7e7c-ccf1-4af9-a4fb-b02d95a23622" />

Añadiendo el `Debug.DrawRay` se puede ver la dirección en la que se mueve la esfera, lo que ayuda a ver  hacia donde va la esfera.

<img width="2870" height="1580" alt="VideoEjercicio13_red" src="https://github.com/user-attachments/assets/8a7196e4-b716-424c-80df-21a7ee2c7fe6" />





