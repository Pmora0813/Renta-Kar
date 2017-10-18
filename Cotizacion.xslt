<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <body>
        <h2>Cotización</h2>
        <table>
          <tr bgcolor="#9acd32">
            <th colspan="2">Cliente</th>
          </tr>
          <tr>
            <td>Nombre:</td>
            <td>
              <xsl:value-of select="Cotizacion/Cliente/@Nombre"/>
            </td>
          </tr>
          <tr>
            <td>E-mail</td>
            <td>
              <xsl:value-of select="Cotizacion/Cliente/@Email"/>
            </td>
          </tr>
          <tr bgcolor="#9acd32">
            <th colspan="2">Fechas</th>
          </tr>
          <tr>
            <td>Inicio:</td>
            <td>
              <xsl:value-of select="Cotizacion/Fechas/@Inicio"/>
            </td>
          </tr>
          <tr>
            <td>Final</td>
            <td>
              <xsl:value-of select="Cotizacion/Fechas/@Final"/>
            </td>
          </tr>
          <tr>
            <td>Dias</td>
            <td>
              <xsl:value-of select="Cotizacion/Fechas/@Dias"/>
            </td>
          </tr>
          <tr bgcolor="#9acd32">
            <th colspan="2">Vehículo</th>
          </tr>
          <tr>
            <td>Tipo:</td>
            <td>
              <xsl:value-of select="Cotizacion/TipoVehiculo/@Nombre"/>
            </td>
          </tr>
          <tr>
            <td>Costo diario</td>
            <td>
              <xsl:value-of select="Cotizacion/TipoVehiculo/@CostoDia"/>
            </td>
          </tr>
          <tr bgcolor="#9acd32">
            <th colspan="2">Seguros</th>
          </tr>
          <xsl:for-each select="Cotizacion/Seguros/Seguro">
            <tr>
              <td colspan="2">
                <xsl:value-of select="."/>
              </td>
            </tr>
          </xsl:for-each>
          <tr bgcolor="#9acd32">
            <th colspan="2">Extras</th>
          </tr>
          <xsl:for-each select="Cotizacion/Extras/Extra">
            <tr>
              <td colspan="2">
                <xsl:value-of select="."/>
              </td>
            </tr>
          </xsl:for-each>
          <tr bgcolor="#9acd32">
            <th colspan="2">Impuestos</th>
          </tr>
          <xsl:for-each select="Cotizacion/Impuestos/Impuesto">
            <tr>
              <td colspan="2">
                <xsl:value-of select="."/>
              </td>
            </tr>
          </xsl:for-each>
          <tr bgcolor="#9acd32">
            <th>Total:</th>
            <th>
              <xsl:value-of select="Cotizacion/Total"/>
            </th>
          </tr>
        </table>
      </body>
    </html>
  </xsl:template>

</xsl:stylesheet>