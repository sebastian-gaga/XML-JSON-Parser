<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="/ferma">
		<html>
			<body style="font-family:Arial;font-size:12pt;background-color:#EEEEEE">
				<table border="1">
					<tr>
						<th>Tip</th>
						<th>Spatiu</th>
						<th>Animal</th>
						<th>Familie</th>
						<th>NumarCapete</th>
						<th>Hrana</th>
					</tr>
					<xsl:for-each select="incinta">
						<tr>
							<td>
								<xsl:value-of select="tip"/>
							</td>
							<td>
								<xsl:value-of select="spatiu"/>
							</td>
							<td>
								<xsl:value-of select="animal"/>
							</td>
							<td>
								<xsl:value-of select="familie"/>
							</td>
							<td>
								<xsl:value-of select="numarCapete"/>
							</td>
							<td>
								<xsl:value-of select="hrana"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>

	</xsl:template>
</xsl:stylesheet>