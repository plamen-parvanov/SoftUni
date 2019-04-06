using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    [Test]
    public void WeaponLoseDurabilityAfterAttack()
    {
        //Arange
        var axeAttack = 10;
        var axeDurability = 20;
        var weapon = new Axe(axeAttack, axeDurability);

        var targetHealt = 15;
        var targetExperience = 25;
        var target = new Dummy(targetHealt, targetExperience);

        //Act
        weapon.Attack(target);

        var actualDurabilityPoints = weapon.DurabilityPoints;
        var expectedDurabilityPoints = 19;

        //Assert
        Assert.That(actualDurabilityPoints, Is.EqualTo(expectedDurabilityPoints),
            "Weapon does not lose durability after attack");
    }
}
