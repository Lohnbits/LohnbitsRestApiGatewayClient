using LohnbitsRestApiGateway.Data.MasterData;
using LohnbitsRestApiGateway.Data.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LohnbitsRestApiGatewayClient.Model
{
    public class ServerModel
    {
        public ServerModel()
        {
            _mandantLfdNr = 0;
            _mandantGruppeLfdNr = 0;
            _bearerToken = "";
        }

        /// <summary>
        /// initialisiert den ausgewählten Mandanten
        /// </summary>
        /// <param name="mandantennummer"></param>
        /// <returns></returns>
        public bool SelectCustomer(int mandantennummer)
        {
            var customersResult = WebApiBase.RequestGet<SelectCustomersResult>("masterData/selectCustomers", _bearerToken);

            _mandantGruppeLfdNr = 0;
            _mandantLfdNr = 0;

            if (customersResult?.Customers == null) return false;

            var aktCustomer = customersResult.Customers.FirstOrDefault(_ => _.Mandantennummer == mandantennummer);
            if (aktCustomer == null) return false;

            _mandantLfdNr = aktCustomer.MandantLfdNr;
            _mandantGruppeLfdNr = aktCustomer.MandantGruppeLfdNr;
            return true;
        }

        /// <summary>
        /// gibt eine Liste der Dokumenttypen zurück
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public SelectDocumentTypesResult? SelectDocumentTypes(SelectDocumentTypesRequest request)
        {
            if (request.MandantLfdNr == 0) request.MandantLfdNr = _mandantLfdNr;
            return WebApiBase.RequestGet<SelectDocumentTypesResult>("masterData/selectDocumentTypes", _bearerToken, request);
        }

        /// <summary>
        /// gibt eine Liste der Mitarbeiter zurück
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public SelectEmployeesResult? SelectEmployees(SelectEmployeesRequest request)
        {
            if (request.MandantLfdNr == null && request.MandantGruppeLfdNr == null && request.Mandantennummer == null) request.MandantLfdNr = _mandantLfdNr;
            return WebApiBase.RequestGet<SelectEmployeesResult>("masterData/selectEmployees", _bearerToken, request);
        }

        /// <summary>
        /// initialisiert den ersten Mandanten mit Zugriffsrechten
        /// </summary>
        /// <returns></returns>
        public bool SelectFirstCustomer()
        {
            var customersResult = WebApiBase.RequestGet<SelectCustomersResult>("masterData/selectCustomers", _bearerToken);
            
            if (customersResult?.Customers == null || customersResult.Customers.Count() < 1)
            {
                _mandantGruppeLfdNr = 0;
                _mandantLfdNr = 0;
                return false;
            }
            else
            {
                var aktCustomer = customersResult.Customers.First();
                _mandantLfdNr = aktCustomer.MandantLfdNr;
                _mandantGruppeLfdNr = aktCustomer.MandantGruppeLfdNr;
                return true;
            }
        }

        /// <summary>
        /// meldet den Benutzer beim Gateway an
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            var loginRequest = new LoginRequest(username, password);
            var loginResult = WebApiBase.RequestGet<LoginResult>("session/login", "", loginRequest);
            _bearerToken = loginResult?.Token ?? "";
            return !string.IsNullOrEmpty(_bearerToken);
        }

        /// <summary>
        /// meldet den Benutzer beim Gateway ab
        /// </summary>
        public void Logout()
        {
            WebApiBase.RequestGet<Task>("session/logout", _bearerToken);
        }

        /// <summary>
        /// gibt den aktuellen Mandanten zurück
        /// </summary>
        public int MandantLfdNr
        {
            get => _mandantLfdNr;
        }

        /// <summary>
        /// gibt die aktuelle Mandantengruppe zurück
        /// </summary>
        public int MandantGruppeLfdNr
        {
            get => _mandantGruppeLfdNr;
        }

        private int _mandantLfdNr;

        private int _mandantGruppeLfdNr;

        private string _bearerToken;
    }
}
