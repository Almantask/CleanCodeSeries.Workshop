using System;
using System.Collections.Generic;
using System.Text;
using WorkshopPresentation.Bad1;
using WorkshopPresentation.Bad7;

namespace WorkshopPresentation.Bad
{
    class Person
    {
        // Extension + Number. Varies based on country
        // Problem: The format is inconsistent.
        public string PhoneNumber { get; }
        // Other person stuff
    }


    // Gender *is not* a person. Person *has a* gender
    class Male: Person
    {   
    }

    // We have more complex entities like teacher, student. 
    // Going beyond scope of human like tiger, bird breaks it too
    class Female : Person
    {
    }
}

namespace WorkshopPresentation.Bad2
{
    class Person
    {
        // Problem: Code and Number are coupled
        public string PhoneNumber { get; }
        public string CountryCode { get; }
        // Other person stuff
    }


    // Gender *is not* a person. Person *has a* gender
    class Male : Person
    {
    }

    // We have more complex entities like teacher, student. 
    // Going beyond scope of human like tiger, bird breaks it too
    class Female : Person
    {
    }
}
    
namespace WorkshopPresentation.Bad1
{
    class PsychicalEducationTeacher
    {
        // Meaningless more often than not
        private VolleyBall _volleyBall;
        private BasketBall _basketBall;
        private Football _football;

        public void GiveVoleyBallLesson()
        {
            // After lesson, ball will probably be disposed, nulled
            _volleyBall = GetVolleyBall();
            // Lesson Stuff- work with ball
        }
        public void GiveFootBallLesson()
        {
            _football = GetFootBall();
            // Lesson Stuff- work with ball
        }
        public void GiveBasketBallLesson()
        {
            _basketBall = GetBasketBall();
            // Lesson Stuff- work with ball
        }

        private VolleyBall GetVolleyBall()
        {
            throw new NotImplementedException();
        }
        private BasketBall GetBasketBall()
        {
            throw new NotImplementedException();
        }
        private Football GetFootBall()
        {
            throw new NotImplementedException();
        }
    }
}

namespace WorkshopPresentation.Ok1
{
    class PsychicalEducationTeacher
    {
        public void GiveVoleyBallLesson(VolleyBall ball)
        {
            // Lesson Stuff- work with ball
        }
        public void GiveFootBallLesson(Football ball)
        {
        }
        public void GiveBasketBallLesson(BasketBall ball)
        {
        }
    }
}

namespace WorkshopPresentation.Bad4
{
    class File
    {
        public string Name { get; }
        public string Extension { get; }
        public string Path { get; }

        public File(string name, string extension, string path)
        {
            Name = name;
            Extension = extension;
            Path = path;
        }

        public string Read()
        {
            var contents = "";
            // Implementation for reading contents of a file.
            return contents;
        }

        public void Write(string text)
        {
            // Implementation for writing to file
        }
    }
}

namespace WorkshopPresentation.Bad5
{
    // If implementations are simple, it might not even be a problem.
    // Though for OO flow, it should be put into consideration.
    static class File
    {
        public static string ReadText(string path)
        {
            var contents = "";
            // Implementation for reading contents of a file.
            return contents;
        }

        public static void WriteText(string text, string path)
        {
            // Implementation for writing to file
        }
    }
}

namespace WorkshopPresentation.Ok4
{
    // The implementation really depends. Here, we might have multiple types of file.
    // For multiple types of files, we might apply different readers or writers.
    class File
    {
        // Static approach is not so good, because we want to inject implementations.
        // We do not want to be bound to one thing.
        public string Name { get; }
        public string Extension { get; }
        public string Path { get; }

        private IFileReader _reader;
        private IFileWriter _writer;

        public File(string name, string extension, string path, IFileReader reader, IFileWriter writer)
        {
            Name = name;
            Extension = extension;
            Path = path;

            _reader = reader;
            _writer = writer;
        }

        // Change for reading or writing now happens outside of the class.
        public string Read() => _reader.Read();
        public void Write(string text) => _writer.Write(text);
    }

    
}

namespace WorkshopPresentation.Bad5
{
    // In this case this is useless.
    // But if we look at a service layer,
    // we might see cases where a service is simply a delegate. 
    // Though in such cases, service does some sort of routing.
    // Routing is a responsibility in itself.
    // This is simply false encapsulation
    static class OvercomplexFile
    {
        public static string Read(string path) => File.ReadText(path);
        public static void Write(string path, string text) => File.WriteText(text, path);
    }
}

namespace WorkshopPresentation.Bad6
{
    public class PhoneNumber
    {
        // Phone number stuff..
        IPhoneNumberFormatter _formatter;

        // For phone numbers in different countries, 
        // we might want to introduce different formatting
        public PhoneNumber(IPhoneNumberFormatter formatter, /**/)
        {
            _formatter = formatter;
        }

        public override string ToString() => _formatter.Format(this);
    }

    // Very small responsibility
    public interface IPhoneNumberFormatter
    {
        string Format(PhoneNumber number);
    }

}

namespace WorkshopPresentation.Ok6
{
    public class PhoneNumber
    {
        // For phone numbers in different countries, 
        // we might want to introduce different formatting
        public PhoneNumber(/**/)
        {
        }

        public override string ToString() => FormatNumber();

        private string FormatNumber()
        {
            return "";
        }
    }

    // Very small responsibility
    public interface IPhoneNumberFormatter
    {
        string Format(PhoneNumber number);
    }

}

namespace WorkshopPresentation.Ok7
{
    public class GodOfWar
    {
        private readonly IMover _mover;
        private readonly IKiller _killer;
        private readonly IHealer _healer;
        private readonly IDamager _damager;
        public GodOfWar(IMover mover, IKiller killer)
        {
            _mover = mover;
            _killer = killer;
        }

        // Many pieces, which focus around the soldier.
        // Using them is a problem because each time,
        // they need to be rewired, restructured and it's not known
        public void PlayWar()
        {
            var shooter = new Soldier();
            var target = new Soldier();

            // Shot should determine if damage is taken or not
            shooter.Shoot(target);
            _damager.Damage(target);
            // Soldier can move by itself
            _mover.Move(shooter, new Vector3D());


            if (target.Hp <= 0)
                // Soldier should know how it dies
                _killer.Kill(target);
            else
                // Soldiers know how to give first aid
                _healer.Heal(target);

        }
    }
}

    namespace WorkshopPresentation.Bad7
{
    class GodOfWar
    {
        public void PlayWar()
        {
            var shooter = new Soldier();
            var target = new Soldier();

            shooter.Shoot(target);
            if (target.IsAlive())
                target.Heal(10);
        }
    }

    public class Soldier: IMoveable, IKillable, IHealer, IDamageDealer
    {
        // A component or not depends on how big are they
        private readonly IMover _mover;
        private readonly IHealingStrategy _healingStrategy;
        private readonly IDamageDealer _damager;

        public int Hp { get; set; }

        public void DealDamage(float damage)
        {
            _damager.DealDamage(damage);
        }

        // Complex behaviour
        public void Heal(Soldier target, float amount) => _healingStrategy.Use(target, amount);
        public void Heal(float amount) => _healingStrategy.Use(amount);
        public void Move(Vector3D location) => _mover.Move(location);
        public void Shoot(Soldier target)
        {

        }

        // Simple behaviour
        public void Die()
        {

        }
        public bool IsAlive()
        {
            return Hp > 0;
        }
        
    }

    public interface IMover
    {
        void Move(Soldier target, Vector3D location);
    }

    public interface IKiller
    {
        void Kill(Soldier target);
    }
}








