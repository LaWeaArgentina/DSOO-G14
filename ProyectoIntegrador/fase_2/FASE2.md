# Fase 2: Análisis previo y funcional

## Tarea 2: Analizar y documentar la fase previa y funcional del sistema "Club deportivo"

Te proponemos:
- Volvé a leer el funcionamiento del Club deportivo. 
- Identificar y documentar los siguientes puntos:
    - Los distintos procesos que contiene el sistema.
    - Las clases con los atributos que intervienen en los procesos.
    - Redactar lógicamente cómo funciona cada proceso.
    - Realizar el boceto de las distintas pantallas que forman la interface de usuario.

### RESOLUCION FASE #2

Rquerimienros originales:
- Registro de los socios y de los no socios.
- Entrega de carnet y cobro de cuota mensual o diaria. 
- Listado diario de los socios que en la fecha les vence la cuota.

Requerimientos en procesos:
- Registrar Alumno (socios o no-socios)
- Pagar cuota
    - Pagar cuota socio
    - Pagar cuota no-socio
- Listar socios con vencimiento hoy

Proceso: Registrar Alumno
- Descripción: Se crea una instancia de Alumno (haciendo uso de las sub-clases SOCIO o NOSOCIO). Se proporciona nombre y apellido y se obtine el ID.
- Atributos: nombre, apellido
- Respuesta: identificador

Proceso: Pagar cuota
- Descripcion: Desde un Alumno se creara y guardara en la lista de pagos del mismo un pago. En el caso de SOCIOS el pago tendra inicio fin el primer dia del mes y fin el ultimo dia del mismo, salvo que se pague ya iniciado el periodo. En este caso comenzará al dia siguiente. Para los NOSOCIOS, el primer u ultimo dia del periodo sera el mismo dia del pago (pago diario).
- Atributos: inicio del periodo, fin del periodo, monto
- Extends:
    - Pago Socio
    - Pago NoSocio

Proceso: Listar socios con vencimiento hoy
- Consulta el estado de pago de cada uno de los socios y agrega en una lista a aquellos que esten finalizando hoy.
- Atributos: -
- Respuesta: Lista de SOCIOS cuyo ultimo PAGO tenga venciomiento hoy

Clases:
- Socio
- NoSocio
- Pago
