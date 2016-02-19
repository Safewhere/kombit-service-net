## STS public certificate
- **Certificate**: Projektmiljø-adgangsstyring-T (funktionscertifikat).cer
- **Thumbprint**: 01 69 9b 6c 50 39 6a c0 60 c8 ae 9b c3 d4 b3 43 c9 b5 7e b1
- **Usage**: The STS public certificate


## Service Consumer certificate (1)
- **Certificate**: FOCES_valid.p12
- **Password**: Test1234
- **Thumbprint**: 15 3e 97 1c 6b ae cc 4e 4e c6 8d 82 69 30 39 01 65 4a 02 a6
- **Usage**: The client certificate which is used for negotiating a security token from Identify*STS

## Service Consumer Certificate (2)
- **Certificate**: VOCES_valid.p12
- **Password**: Test1234
- **Thumbprint**: 46 78 23 72 45 fe dc 80 59 d1 13 67 59 55 df b8 70 d3 6b f4
- **Usage**: The client certificate which is used for negotiating a bootstrap token in normal OBO test or used in OBO proxy test

## Non-authorized Service Consumer Certificate
- **Certificate**: CA95B2F383BEF8144500CD74B88BC42CD3DE936C.p12
- **Password**: Test1234
- **Thumbprint**: CA95B2F383BEF8144500CD74B88BC42CD3DE936C
- **Usage**: Use in one test case SendIssueRequestWhichWillBeFailedBecauseOfAuthentication which is a client credential and it is not mapped to any user in Identify.