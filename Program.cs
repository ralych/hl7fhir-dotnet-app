using System;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;


namespace hl7fhir_app
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello FHIR World!");
      var patient = new Patient();
      patient.Active = true;

      var id = new Identifier();
      id.System = "http://hl7.org/fhir/sid/us-ssn";
      id.Value = "000-12-3456";
      patient.Identifier.Add(id);

      var contact = new Patient.ContactComponent();
      contact.Name = new HumanName();
      contact.Name.Family = "Parks";
      // setup other contact details

      patient.Contact.Add(contact);

      var serializer = new FhirJsonSerializer(new SerializerSettings() { Pretty = true });
      var jsonText = serializer.SerializeToString(patient);
      Console.WriteLine(jsonText);

    }
  }
}
