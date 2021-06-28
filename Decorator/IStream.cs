using System;

namespace Decorator
{
    public interface IStream
    {
        void write(string data);
    }

    public class CloudStream : IStream
    {
        public void write(string data)
        {
            Console.WriteLine("Writing to cloud storage..");
        }

    }
    public class EncryptStream : IStream
    {
        private IStream stream { get; set; }

        public EncryptStream(IStream stream)
        {
            this.stream = stream;
        }

        public void write(string data)
        {
            Console.WriteLine("Encrypting stream..");
            var encryptedData = Encrypt(data);
            this.stream.write(data);
        }

        private object Encrypt(string data)
        {
            return data; // return encrypted data
        }
    }

    public class CompressStream : IStream
    {
        private IStream stream { get; set; }

        public CompressStream(IStream stream)
        {
            this.stream = stream;
        }

        public void write(string data)
        {
            var compressedData = Compress(data);
            Console.WriteLine("Compressing stream..");
            this.stream.write(data);
        }

        private object Compress(string data)
        {
            return data;
        }
    }
}

