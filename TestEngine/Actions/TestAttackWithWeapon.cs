using Engine.Actions;
using Engine.Factories;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEngine.Actions
{
    [TestClass]
    public class TestAttackWithWeapon
    {
        [TestMethod]
        public void Test_Constructor_GoodParameters()
        {
            GameItem pointyStick = ItemFactory.CreateGameItem(1001);
            AttackWithWeapon attackWithWeapon = new AttackWithWeapon(pointyStick, 1, 5);
            Assert.IsNotNull(attackWithWeapon);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Constructor_ItemIsNotAWeapon()
        {
            GameItem granolaBar = ItemFactory.CreateGameItem(2001);

            AttackWithWeapon attackWithWeapon = new AttackWithWeapon(granolaBar, 1, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Constructor_MinimumDamageLessThanZero()
        {
            GameItem pointyStick = ItemFactory.CreateGameItem(1001);

            AttackWithWeapon attackWithWeapon = new AttackWithWeapon(pointyStick, -1, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Constructor_MaximumDamageLessThanMinimumDamage()
        {
            GameItem pointyStick = ItemFactory.CreateGameItem(1001);

            AttackWithWeapon attackWithWeapon = new AttackWithWeapon(pointyStick, 2, 1);
        }
    }
}
