using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class EditMode
{
    private StatsGuy stats;


    [SetUp]
    public void SetUp()
    {
        stats = new StatsGuy();

    }

    [Test]
    public void LifeTest()
    {
        Assert.AreEqual(StatsGuy.DEFAULTHP, stats.life, "The default lives should be " + StatsGuy.DEFAULTHP + " but was " + stats.life);
    }

    [Test]
    public void PowerTest()
    {
        Assert.AreEqual(StatsGuy.DEFAULTPOWER, stats.power, "The default power should be " + StatsGuy.DEFAULTPOWER + " but was " + stats.power);
    }

    [Test]
    public void TypePowerTest()
    {
        Assert.AreEqual(StatsGuy.WATER, stats.getTypeOfDamage(), "The default power should be " + StatsGuy.WATER + " but was " + stats.power);
    }

    [TestCase(false, 6)]
    [TestCase(true, 5)]
    [TestCase(true, 3)]
    public void PowerComprobe(bool expected, int attackPower)
    {
        bool actual = stats.fight(attackPower);
        Assert.AreEqual(expected, actual, "The expected value should be " + expected + " but was " + actual);
    }

    [TestCase(true, 5, StatsGuy.WATER)]
    [TestCase(false, 5, StatsGuy.GRASS)]
    [TestCase(true, 5, StatsGuy.FIRE)]
    public void FightTypeComprobe(bool expected, int power, int type)
    {
        bool actual = stats.fightWithTypeOfDamage(power, type);
        Assert.AreEqual(expected, actual, "The expected value should be " + expected + " but was " + !actual);
    }
}
