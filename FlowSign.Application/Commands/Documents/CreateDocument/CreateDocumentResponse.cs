namespace FlowSign.Application.Commands.Documents.CreateDocument;
using FlowSign.Domain.Enums;
public class CreateDocumentResponse
{
    public Guid Id { get; init; }
    public string Title { get; init; }
    public DocumentStatus Status { get; init; }
    public SigningType SigningType { get; init; }
    public DataTime CreatedAt { get; init; }
    public DataTime ExpiresAt { get; init; }
    public List<Guid> SignerIds { get; init; }

    public CreateDocumentResponse(Guid id, string title, DocumentStatus status, SigningType signingType, DateTime createdAt, DateTime expiresAt, List<Guid> signerIds)
    {
        Id = id;
        Title = title;
        Status = status;
        SigningType = signingType;
        CreatedAt = createdAt;
        ExpiresAt = expiresAt;
        SignerIds = signerIds;
    }

}
