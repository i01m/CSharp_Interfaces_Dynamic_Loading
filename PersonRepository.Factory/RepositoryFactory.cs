using PersonRepository.Interface;
using System;
using System.Configuration;

namespace PersonRepository.Factory
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetRepository()
        {
            string repositoryName = ConfigurationManager.AppSettings["RepositoryType"];
            Type repositoryType = Type.GetType(repositoryName);
            object repository = Activator.CreateInstance(repositoryType);
            IPersonRepository personRepository = repository as IPersonRepository;

            return personRepository;
        }
    }
}
