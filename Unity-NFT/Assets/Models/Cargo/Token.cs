﻿namespace Models.Cargo
{
    public class Token
    {
        public string TokenUrl { get; set; }
        public string Owner { get; set; }
        public TokenMetadata Metadata { get; set; }
        public bool SupportsBatchMint { get; set; }
        public string TokenId { get; set; }
        public string Imprint { get; set; }
    }
}