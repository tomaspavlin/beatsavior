using Hl7.Fhir.Model;

namespace BildMlue.Infrastructure.FHIR.Extensions;

public static class PersonExtensions
{
    public static void SetEmail(this Person person, string email)
    {
        var telecom = person.GetTelecom(ContactPoint.ContactPointSystem.Email);
        telecom.Value = email;
    }

    public static void SetPhone(this Person person, string phone)
    {
        var telecom = person.GetTelecom(ContactPoint.ContactPointSystem.Phone);
        telecom.Value = phone;
    }

    private static ContactPoint GetTelecom(this Person person, ContactPoint.ContactPointSystem system)
    {
        var telecom = person.Telecom.FirstOrDefault(t => t.System == system);
        if (telecom is null)
        {
            telecom = new ContactPoint
            {
                System = system
            };
            person.Telecom.Add(telecom);
        }

        return telecom;
    }
}