﻿using MyDDNS.Registrar.Cloudflare.Api.Models;

namespace MyDDNS.Registrar.Cloudflare.Api.Responses;

public class PatchDnsRecordResponse
{
    public CloudflareDnsRecord? Result { get; set; }
    public bool Success { get; set; }
}