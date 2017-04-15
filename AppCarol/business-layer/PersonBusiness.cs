using System;
namespace AppCarol
{
	/* 
	 * Class to treat all the business rules for entity <Person>
	*/
	public class PersonBusiness
	{
		public PersonBusiness()
		{
		}


		public void addPerson(Person person) 
		{

			if (null == PersonData.getPerson(person))
			{
				PersonData.addPerson(person);

			}
			else 
			{
				throw new BusinessException("Person already registered!");
			}
		}

		public void updatePerson(Person person) 
		{
			PersonData.updatePerson(person);
		}

		public void deletePerson(Person person)
		{
			PersonData.deletePerson(person);
		}
	}
}
