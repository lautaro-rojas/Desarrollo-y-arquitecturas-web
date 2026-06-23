# Diapositivas clase ?

[PPT Modelos](../Clase%209/MODELOS%20%20seguridad%20en%20la%20web.pdf)

1, 2, 3, 4, 5, 6, 9, 10

# 1
Seguridad en la Web

3 caracterísitcas fundamentales:
- Confidencialidad
- Integridad
- Disponibilidad
  
Medidas de seguridad
- Prevención
- Corrección
- Recuperación

# 2
Debemos resaltar el hecho que las medidas de seguridad suele exceder las competencias del sistema como tal. 

Por ej para garantizar la disponibilidad  hay que ir más allá de un buen diseño ya que se depende de otros factores externos como son las comunicaciones y el suministro de energía.

MEDIDAS DE SEGURIDAD DE CARÁCTER TECNICO
- IDENTIFICACION Y AUTENTICACION DE USUARIOS
- CONTROL DE ACCESO
- CONTROL DE FLUJO DE LA INFORMACION
- CONFIDENCIALIDADINTEGRIDAD
- NO REPUDIO
- AUDITORIA

# 3
MEDIDAS  DE SEGURIDAD DE   CARÁCTER ADMINISTRATIVO/ORGANIZATIVO
- Clasificación de la información de acuerdo con el nivel de confidencialidad
- Asignación de responsabilidades a los usuarios
- Establecimiento de funciones de seguridad
- Formación de usuarios.

MECANISMOS  DE  PROTECCION
- AUTENTICACION
- CONTROL DE ACCESOS
- CIFRADO DE DATOS
- FUNCIONES RESUMEN
- REGISTRO DE AUDITORIA 
- FIRMA DIGITAL

# 4
Los Sistemas Distribuidos requieren de diversos puntos de comprobación y cumplimiento
- Punto de decisión de la política (PDP, Policy Decision Point)(en el que se toma una decisión de ctrol de acceso)
- Punto de cumplimiento de la política (PEP, Policy Enforcement Point)(en el que se efectúa el ctrol de acceso como tal de acuerdo con la respuesta  emitida por el PDP pudiendo existir varios PDP y PEP repartidos por el sistema)

Un ejemplo de política de seguridad es el de las fuerzas armadas
Tiene 5 niveles de seguridad clásicos:
- desclasificado
- restringido
- confidencial
- secreto
- ultra secreto

# 5
MODELOS   DE  SEGURIDAD

## Control de acceso obligatorio - MAC (Mandatory Access Control)
Son modelos de seguridad multinivel que representa la información estructurada en rangos de sensibilidad.

## Control de acceso discrecional- DAC ( Discretionary Access Control)
Se lo llama también modelos de seguridad limitada. No se centran en prevenir el flujo de la información sino que se basan en que el dueño de un objeto que coincide habitualmente con su autor tiene el control sobre los permisos de ese objeto, de ahí que los administre a su discreción

## Control de acceso basado en roles RBAC (Role Based Access Control)
Usa el concepto de rol para agrupar un conjunto de permisos y un conjunto de usuarios autorizados a ejercer dichos permisos.

# 6
LOS MECANISMOS DE SEGURIDAD RELACIONADO CON EL CTROL DE ACCESOSON:
- abstracción de datos
- privilegios mínimos
- separación de privilegios
- separación de  administración y accesos
- autorizaciones positivas y negativas
- delegación de privilegios
- transacciones bien formadas
- autenticación
- compartición mínima
- diseño abierto•exigencia de permisos
- intermediación completa
- mecanismos económicos
- sencillez de uso y aceptabilidad

# 9
CALIDAD   EN  EL  DESARROLLO  WEB
La norma   ISO 8402[12] define la calidad como el conjunto de propiedades y de características de  un producto ó servicio, que le confieren aptitud para satisfacer unas  necesidades explícitas ó implícitas 

Basándose en el modelo de Mc Call, surgió el modelo ISO 9126[11];

Un modelo normalizado que permite evaluar y comparar productos sobre la misma base. En este modelo, la calidad queda definida  a un alto nivel de abstracción por seis características principales:
- Funcionalidad
- Fiabilidad
- Usabilidad
- Eficiencia
- Mantenibilidad
- Portabilidad

Este estándar no incluye métricas ni métodos de evaluación de dichas  características por lo tanto se revisó la última norma y se le incluyó lo que tuviera que ver con el grado de excelencia. Para ello distingue 3 diferentes aproximaciones a la calidad de un producto

# 10
- Calidad Interna: Se mide por las propiedades estáticas del código usando técnicas de inspección
- Calidad Externa: Se mide por las propiedades dinámicas del código cuando ésta se ejecuta.
- Calidad en Uso: Se mide por el grado por el cual el software está realizado en función de las necesidades del usuario en el entorno de trabajo para el que fue construido.