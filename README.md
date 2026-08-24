# Laboratorio #1 — Herramientas de la Programación Aplicada III (.NET)

Soluciones de las tres prácticas del Laboratorio #1 del curso **Herramientas de la Programación Aplicada III (.Net)**.

- **Docente:** Ing. Irina Fong
- **Estudiante:** Diego Sanjur

---

## Tecnologías

| Elemento | Detalle |
|---|---|
| Lenguaje | C# |
| Plantilla | Aplicación de Windows Forms (.NET Framework) |
| Framework | .NET Framework 4.7.2 |
| IDE | Visual Studio 2022 |

---

## Estructura del repositorio

```
.
├── Pract1-Controles/      # Práctica #1 — Controles básicos y armado de fecha
├── Descuentos/            # Práctica #2 — Descuentos por rango de venta
└── Pract8-EstructuraIf/   # Práctica #3 — Calculadora con GroupBox y RadioButtons
```

Cada carpeta contiene su propia solución (`.sln`) independiente.

---

## Práctica #1 — `Pract1-Controles`

Formulario que recibe día, mes y año en tres `TextBox` y arma la fecha completa en un `Label`.

**Funcionalidad**
- **Botón Mostrar:** concatena los tres valores separados por espacios y los muestra en el label `La fecha es:`. Antes de mostrar, valida que ningún `TextBox` esté vacío.
- **Botón Finalizar:** muestra un primer `MessageBox` con el texto *"Se cerrará la ventana"*, luego un segundo con la palabra *"Cerrando"*, y finalmente cierra el formulario con `this.Close()`.

**Conceptos aplicados**
- Concatenación de cadenas con los operadores `+` y `+=`
- `MessageBox.Show` con texto, título, `MessageBoxButtons` y `MessageBoxIcon`
- Propiedades `Label.Text` y `TextBox.Text`
- Validación de campos vacíos con `string.IsNullOrWhiteSpace`

**Nomenclatura de controles:** `lbl` para etiquetas, `txt` para cajas de texto, `btn` para botones.

---

## Práctica #2 — `Descuentos`

Calcula el descuento aplicable a una venta según su monto, y muestra el porcentaje, el descuento en dólares y la venta final.

**Reglas de negocio**

| Valor de la venta | Descuento |
|---|---|
| ≥ $500 | 30 % |
| $300 – $499 | 20 % |
| $100 – $299 | 10 % |
| ≤ $100 | 0 % |

**Funcionalidad**
- **Calcular:** valida la entrada, determina el porcentaje con una cadena `if / else if / else` y llena los campos de resultado.
- **Limpiar:** vacía todos los `TextBox` del formulario.
- **Salir:** notifica al usuario con un `MessageBox` y cierra la aplicación.

**Conceptos aplicados**
- Tipo `decimal` para montos monetarios (precisión exacta, sin errores de redondeo de punto flotante; equivale a `DECIMAL` / `NUMERIC` en SQL)
- Conversión segura con `decimal.TryParse` usando el parámetro `out` dentro de un `if`
- Operadores lógicos condicionales (`&&`, `||`) con evaluación de cortocircuito
- Uso del sufijo literal `m` para constantes decimales (`0.30m`)

---

## Práctica #3 — `Pract8-EstructuraIf`

Calculadora de dos operandos donde la operación depende del `RadioButton` seleccionado. Los radios se agrupan dentro de un `GroupBox` para mantenerlos aislados dentro del formulario.

**Funcionalidad**
- Operaciones disponibles: **Suma**, **Resta**, **Multiplicación** y **División**.
- El símbolo mostrado entre los dos operandos (`+`, `-`, `*`, `/`) cambia dinámicamente según la opción seleccionada.
- La propiedad `Text` del formulario muestra **PRÁCTICA DE ESTRUCTURA IF**.
- Se mantienen las validaciones de las prácticas anteriores (campos no vacíos, conversión segura) y se controla la división entre cero.

**Conceptos aplicados**
- Control `GroupBox` para agrupar controles relacionados
- Control `RadioButton` y su propiedad `Checked`
- Estructura de decisión `if / else if / else`

---

## Cómo ejecutar

1. Clonar el repositorio:
   ```bash
   git clone <url-del-repositorio>
   ```
2. Abrir el archivo `.sln` de la práctica deseada en Visual Studio.
3. Restaurar el proyecto si es necesario y presionar **F5** (o Ctrl + F5) para compilar y ejecutar.

> Requiere tener instalado el **.NET Framework 4.7.2 Developer Pack** y la carga de trabajo *Desarrollo de escritorio de .NET* en Visual Studio.

---

## Convenciones de código

| Prefijo | Control |
|---|---|
| `lbl` | Label |
| `txt` | TextBox |
| `btn` | Button |
| `rbt` | RadioButton |
| `grp` | GroupBox |

Todos los formularios muestran en su barra de título el nombre de la aplicación seguido de *Programado por: Nombre Apellido*, según lo indicado en el enunciado.
