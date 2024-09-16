namespace UserEntityTest.cs
{
    public class Tests
    {


        [Test]
        public void PasswordLengthMustMore8Symbols()
        {
            var userEntity = new UserEntity()
            {
                firstname = "Евгений",
                lastname = "Кобля",
                password = "12345678",
                email = "koblia.eo@gmail.com"
            };
            Assert.That(userEntity.password.Length>=8);
        }
    }
}