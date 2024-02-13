namespace HotelRent {
    class Rent {

        public string Nome { get; set; }
        public string Email { get; set; }

        public Rent(string nome, string email) {
            Nome = nome;
            Email = email;
        }

        public override string ToString() {
            return Nome + ", " + Email;
        }
    }
}

