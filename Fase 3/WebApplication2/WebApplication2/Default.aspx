<%@ Page Title="Ninty" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ninty</h1>
    </div>
    
        <div class="container" runat="server" id="tab1">
	<div class="row">
		<div class="col-xs-12 col-sm-8 col-sm-offset-2 col-md-6 col-md-offset-3 col-lg-6 col-lg-offset-3">
			<h2>Iniciar Sesion o Registrarse</h2>
            <asp:ValidationSummary runat=server 
                CssClass="alert alert-danger"
                HeaderText="Usuario o Contraseña invalidos" 
                ValidationGroup="ISesion"
                />
            <asp:ValidationSummary runat=server 
                CssClass="alert alert-danger"
                HeaderText="Los siguentes datos son incorrectos:" 
                ValidationGroup="Registrar"
                />
			<ul class="nav nav-tabs">
				<li class="active"><a data-toggle="tab" href="#signin">Iniciar Sesion</a></li>
				<li><a data-toggle="tab" href="#signup">Registrarse</a></li>
			</ul>

			<div class="tab-content">
				<div id="signin" class="tab-pane fade in active">
					<h3>Iniciar Sesion</h3>
						<div class="form-group">
							<input type="email" name="user" placeholder="Correo.." class="form-control" id="user" runat="server">
                            <asp:RequiredFieldValidator runat=server 
                                ControlToValidate=user
                                ValidationGroup="ISesion"
                                ErrorMessage="Ingrese correo electronico"> *
                            </asp:RequiredFieldValidator>
						</div>
						<div class="form-group">
							<input type="password" name="password" placeholder="Contraseña..." class="form-control" id="password" runat="server">
						</div>
                        <div>
                            <h5 id="UserName" runat="server"></h5>
                        </div>
						<div class="form-group">
                            <asp:Button ID="SubIS"
                                Text="Iniciar Session"
                                class="btn btn-default"
                                type="button"
                                OnClick="SubIS_Click"
                                runat="server"
                                causesvalidation="true"
                                validationgroup="ISesion"/>
						</div>
				</div>
				<div id="signup" class="tab-pane fade">
					<h3>Registrarse</h3>
                    <div class="form-group">
							<input type="email" name="Umail" placeholder="Correo Electronico..." class="form-control" runat="server" id="Umail">
                            <asp:RequiredFieldValidator runat=server 
                                ControlToValidate=Umail
                                ValidationGroup="Registrar"
                                ErrorMessage="Ingrese Correo"> *
                            </asp:RequiredFieldValidator>
						</div>
						<div class="form-group">
							<input type="text" name="uname" placeholder="Nombre..." class="form-control" runat="server" id="uname">
                            <asp:RequiredFieldValidator runat=server 
                                ControlToValidate=uname
                                ValidationGroup="Registrar"
                                ErrorMessage="Ingrese Nombre"> *
                            </asp:RequiredFieldValidator>
						</div>
                        <div class="form-group">
							<input type="text" name="apellido" placeholder="Apellido..." class="form-control" runat="server" id="apellido">
						</div>
						<div class="form-group">
							<input type="password" name="password" placeholder="Contraseña..." class="form-control" id="password1" runat="server" >
                            <asp:RequiredFieldValidator runat=server 
                                ControlToValidate=password1
                                ValidationGroup="Registrar"
                                ErrorMessage="Ingrese Contraseña"> *
                            </asp:RequiredFieldValidator>
						</div>
						<div class="form-group">
							<input type="password" name="password2" placeholder="Verifica Contraseña..." class="form-control" id="password2" runat="server">
                            <asp:RequiredFieldValidator runat=server 
                                ControlToValidate=password2
                                ValidationGroup="Registrar"
                                ErrorMessage="Ingrese Contraseña nuevamente"> *
                            </asp:RequiredFieldValidator>
                             <asp:CompareValidator runat=server
                                ControlToValidate=password2
                                ControlToCompare=password1 
                                 ValidationGroup                                                                                                                                                                                                            ="Registrar"
                                ErrorMessage="La Contraseña no es la misma" />*
						</div>
                            <h3>Pago</h3>
                            <p>Seleccione tipo de suscripcion</p>
                            <div class="form-group">
                                <div class="radio">
                                    <label><input type="radio" name="optradio" id="op1" runat="server" checked>Opcion 1 $4.99 por 1 mes</label>
                                </div>
                                <div class="radio">
                                    <label><input type="radio" name="optradio" id="op2" runat="server">Opcion 2 $14.99 por 1 año</label>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="control-label" for="cvv">Numero de Usuarios</label>
                                <input type="number" class="form-control" name="nu" id="nu" placeholder="Numero de Usuarios" runat="server" value="0" min="0" max="99">
                                <asp:Label runat="server">$2.00 por usuario</asp:Label>
                            </div>
                            <div class="form-group">
                                <label class="control-label" for="cname">Nombre en la tarjeta</label>
                                <input type="text" class="form-control" name="cname" id="cname" placeholder="Nombre en la tarjeta" runat="server"> 
                                <asp:RequiredFieldValidator runat=server 
                                ControlToValidate=cname
                                ValidationGroup="Registrar"
                                ErrorMessage="Ingrese Nombre de la Tarjeta"> *
                            </asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group">
                                <label class="control-label" for="card-number">Numero de la tarjeta</label>
                                <input type="number" class="form-control" name="card-number" id="cnumber" placeholder="Numero de tarjeta Debito/Credito" runat="server" min="0" max="9999999999999999">
                                <asp:RequiredFieldValidator runat=server 
                                ControlToValidate=cnumber
                                ValidationGroup="Registrar"
                                ErrorMessage="Ingrese Numero de la tarjeta de credito"> *
                            </asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group">
                                <label class="control-label" for="expiry-month">Fecha de Expiracion</label>
                                    <div class="row">
                                            <select class="form-control" name="expiry-month" id="mes" runat="server">
                                                <option value="01">Enero</option>
                                                <option value="02">Febrero</option>
                                                <option value="03">Marzo</option>
                                                <option value="04">Abril</option>
                                                <option value="05">Mayo</option>
                                                <option value="06">Junio</option>
                                                <option value="07">Julio</option>
                                                <option value="08">Agosto</option>
                                                <option value="09">Septiembre</option>
                                                <option value="10">Octubre</option>
                                                <option value="11">Noviembre</option>
                                                <option value="12">Diciembre</option>
                                            </select> 
                                            <asp:RequiredFieldValidator runat=server 
                                                ControlToValidate=mes
                                                ValidationGroup="Registrar"
                                                ErrorMessage="Ingrese Mes de Expiracion"> *
                                            </asp:RequiredFieldValidator>
                                            <select class="form-control" name="expiry-year" id="year" runat="server">
                                                <option value="13">2013</option>
                                                <option value="14">2014</option>
                                                <option value="15">2015</option>
                                                <option value="16">2016</option>
                                                <option value="17">2017</option>
                                                <option value="18">2018</option>
                                                <option value="19">2019</option>
                                                <option value="20">2020</option>
                                                <option value="21">2021</option>
                                                <option value="22">2022</option>
                                                <option value="23">2023</option>
                                                <option value="24">2024</option>
                                                <option value="25">2025</option>
                                            </select>
                                        <asp:RequiredFieldValidator runat=server 
                                            ControlToValidate=year
                                            ValidationGroup="Registrar"
                                            ErrorMessage="Ingrese Año de expiracion"> *
                                        </asp:RequiredFieldValidator>
                                        </div>
                                </div>
                                  <div class="form-group">
                                    <label class="control-label" for="cvv">CVV</label>
                                    <input type="number" class="form-control" name="cvv" id="cvv" placeholder="Codigo de Seguridad" runat="server" min="0" max="9999">
                                      <asp:RequiredFieldValidator runat=server 
                                        ControlToValidate=cvv
                                        ValidationGroup="Registrar"
                                        ErrorMessage="Ingrese Codigo de Seguridad"> *
                                    </asp:RequiredFieldValidator>
                                  </div>
						<div class="form-group">
                            <asp:Button ID="Button2"
                                Text="Registrarse"
                                class="btn btn-default"
                                type="button"
                                autopostback="false"
                                OnClick="Button2_Click"
                                runat="server" 
                                causesvalidation="true"
                                validationgroup="Registrar"
                                />
						</div>
				</div>
			</div>
		</div>
	</div>
    </div>
                <div id="confirmar" visible="false" runat="server">
                    <h1>Confirmar Pago</h1>
                    <h4 id="nombre" runat="server"></h4>
                    <h4 id="Pcorreo" runat="server"></h4>
                    <h4 id="Psuscripcion" runat="server"></h4>
                    <h4 id="PUsuarios" runat="server"></h4>
                    <h4 id="total" runat="server"></h4>
                <asp:Button ID="ConfirmarPago"
                                Text="Confirmar Pago"
                                class="btn btn-default"
                                type="button"
                                OnClick="ConfirmarPago_Click"
                                runat="server" 
                                />
                <asp:Button ID="Cancelar"
                                Text="Cancelar"
                                class="btn btn-default"
                                type="button"
                                OnClick="Cancelar_Click"
                                runat="server" 
                                />
                </div>
    
</asp:Content>
