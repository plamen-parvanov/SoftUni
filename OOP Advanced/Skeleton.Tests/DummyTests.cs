using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    [Test]
    public void Dummy_LoseHelt_WhenAttacked()
    {
        //Arrange
        var dummyHealt = 2;
        var dummyExperience = 10;
        var dummy = new Dummy(dummyHealt, dummyExperience);

        var attackPoints = 1;

        //Act
        dummy.TakeAttack(attackPoints);

        //Assert
        var actualDummyHealt = dummy.Health;
        var expectedDummyHealt = 1;
        Assert.That(actualDummyHealt, Is.EqualTo(expectedDummyHealt),
            "Dummy does not lose healt.");
    }

    [Test]
    public void DeadDummy_ThrowsException_IfAttacked()
    {
        //Arange
        var dummyHealt = 1;
        var dummyExperience = 10;
        var dummy = new Dummy(dummyHealt, dummyExperience);

        var attackPoints = 5;

        //Act
        dummy.TakeAttack(attackPoints);

        //Assert
       Assert.That(() => dummy.TakeAttack(attackPoints),
           Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
    }

    [Test]
    public void Dummy_WhenDies_CanGiveExperience()
    {
        //Arange
        var dummyExperience = 10;
        var dummyHealth = 1;
        var dummy = new Dummy(dummyHealth, dummyExperience);

        //Act
        var attackTaken = 2;
        dummy.TakeAttack(attackTaken);
        var actualGivenExperience = dummy.GiveExperience();

        //Assert
        var expectedGivenExperience = 10;
        Assert.That(actualGivenExperience, Is.EqualTo(expectedGivenExperience));
    }

    [Test]
    public void AliveDummy_WhenTriesToGiveExperience_ThrowsException()
    {
        //Arange
        var dummyHealt = 1;
        var dummyExperience = 10;
        var dummy = new Dummy(dummyHealt, dummyExperience);

        //Assert
        Assert.That(() => dummy.GiveExperience(),
            Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
    }
}
