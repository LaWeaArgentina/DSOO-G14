# Fase 1 - Análisis preliminar 

Te proponemos llevar a cabo el análisis preliminar para: 
- Conocer el funcionamiento del Instituto Terciario
- Identificar y marcar las clases y los atributos con dos colores diferentes.

## Tarea 1: Analizar el funcionamiento del club deportivo

Para resolver la tarea te proponemos:
- Leer el enunciado del funcionamiento del club deportivo.
- Identificar clases y atributos.
- Documentar el análisis para tenerlo a disposición en las próximas semanas.

### RESOLUCION FASE #1

> Se listan las clases, sus subclases y se mencionan atributos y metódos básicos entre corchetes

- Persona [ nombre, apelido, identificador ]
    - Alumno[ pagos, rutina, vencimiento, pagar(), obtenerEstadoPago() ]
        - Socio [ obtenerEstadoPago(), pagar() ]
        - NoSocio [ obtenerEstadoPago(), pagar() ]
    - Profesore [ alumnos, sueldo ]
- Rutina [ descripcion ]
- Pago [ periodoInicio, periodoFin ]

> Ver Fase1_UMLClassDiagram
