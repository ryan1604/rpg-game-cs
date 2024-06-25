﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using d20Tek.DiceNotation;
using d20Tek.DiceNotation.DieRoller;
using d20Tek.DiceNotation.Results;

namespace SOSCSRPG.Core
{
    public class DiceService : IDiceService
    {
        private static readonly IDiceService _instance = new DiceService();

        private DiceService() { }

        public static IDiceService GetInstance => _instance;

        public IDice Dice { get; } = new Dice();
        public IDieRoller DieRoller { get; private set; } = new RandomDieRoller();
        public IDiceConfiguration Configuration => Dice.Configuration;
        public IDieRollTracker RollTracker { get; private set; } = null;

        public void configure(IDiceService.RollerType rollerType, bool enableTracker = false, int constantValue = 1)
        {
            RollTracker = enableTracker ? new DieRollTracker() : null;
            switch (rollerType)
            {
                case IDiceService.RollerType.Random:
                    DieRoller = new RandomDieRoller(RollTracker);
                    break;
                case IDiceService.RollerType.Crypto:
                    DieRoller = new CryptoDieRoller(RollTracker);
                    break;
                case IDiceService.RollerType.MathNet:
                    DieRoller = new MathNetDieRoller(RollTracker);
                    break;
                case IDiceService.RollerType.Constant:
                    DieRoller = new ConstantDieRoller(constantValue);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(rollerType));
            }
        }

        public DiceResult Roll(string diceNotation) => Dice.Roll(diceNotation, DieRoller);

        public DiceResult Roll(int sides, int numDice = 1, int modifier = 0)
        {
            DiceResult result = Dice.Dice(sides, numDice).Constant(modifier).Roll(DieRoller);
            Dice.Clear();
            return result;
        }
    }
}
