# Clase 5

## Ejercicio durante la clase

Cálculo de un presupuesto de viajes.

![EjerClas5](../images/EjerClas5.jpeg)

Control: Días que no sea mayor a 15 y que estes obligado a ponerlo.

[Ir al código]()

## Preguntas que pueden estar en el parcial

Temas importantes:

- Como es un anclaje local y un externo?
- Ciclo de vida de un ASP primitivo?

    Cliente

    ```HTML
    html
    head
        script
            funcion clacular y un submit
        /script
    /head

    body
        form
            funcion calcuar instnciada en script
        /form
    /body

    /html
    ```

    Servidor: recepcion de lo que viene del cliente a traves del submit + lógica + envio de datos al cliente

- Expires es el metodo que me dice que una cookie no es persistente?
  
  No. Expires no es un metodo, es una propiedad.

- Para que me sirve una variable de sesion?
- Modelo de objetos, cuales son los objetos: request response, server, application
- De cada objeto grafique el modelo de objetos, Ej: Objeto Server: CreateObjet
- `Global.asax` es un archivo de configuración pero esta intimiamente ligado a .net, por que y en donde?
- Cuales son los otros archivos de config?
  - web config
  - machine config
- ¿Cuales son los eventos en el objeto sesion y application? onstart y onend
- ¿Para que me sirve la propiedad haskeys? es booleana si es verdadera estas dentro de un diccionario de cookies
- ¿Cómo se puede recorrer una colexión de cookies?
- ¿Qué es una coleccion comun o un diccionario de cookies?
- ¿Cómo identifico un archivo html o aspx?
  
  Cuando en el codigo veo response o request es un aspx
- ¿El cliente que recive?
  
  Un HTML como respuesta

## TP

1er entrega: Casos de uso, login y bitacora.

- Carpeta:
  - Solapas:
    - interfaz de usuario
      - Ide de desarrollo con las clases
      - aspx de la interfaz de usuario
      - codigo
      - Solo el codigo de login que lo autentica, quiere el diagrama ese que no me acuerdo como se llama, de secuencia? No quiere un diagrama exacto de secuencia. es mas conceptual, con el fragmento de código dentro.
    - Acceso a datos
    - Capa de negocios
    - Capa de entidades

Necesita que en el TP haya un regular expression validation (nos dio una hoja con la explicación).
