using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using uh_sample.CustomAttributes;
using uh_sample.Validations;

namespace uh_sample.Models
{
    /// <summary>ServiceEventsDTO class</summary>
    public class ServiceEventDto
    {
        /// <summary>
        /// EventId
        /// </summary>
        [DoNotPatch]
        public int? Id { get; set; }
        
        /// <summary>
        /// ParentEventId
        /// </summary>
        public int? ParentEventId { get; set; }
        
        /// <summary>
        /// AssetId
        /// </summary>
        [Required(ErrorMessage = "Asset id is required.")]
        public long AssetId { get; set; }

        /// <summary>
        /// AccountId
        /// </summary>
        public long AccountId { get; set; }
        
        /// <summary>
        /// Sequence
        /// </summary>
        public int? Seq { get; set; }
        
        /// <summary>
        /// ShortDescription
        /// </summary>
        [MaxLength(50, ErrorMessage = "Short description cannot be longer than 50 characters.")]
        public string ShortDesc { get; set; }

        /// <summary>
        /// LongDescription
        /// </summary>
        //[Required(ErrorMessage = "Description is required.")]
        [MaxLength(255, ErrorMessage = "Description cannot be longer than 255 characters.")]
        public string LongDesc { get; set; }

        /// <summary>
        /// ItemResult
        /// </summary>
        [MaxLength(25, ErrorMessage = "Item result cannot be longer than 25 characters.")]
        public string ItemResult { get; set; }

        /// <summary>
        /// TemplateId
        /// </summary>
        public int? TemplateId { get; set; }

        /// <summary>
        /// EventTypeId
        /// </summary>
        [Required(ErrorMessage = "Event type id is required.")]
        public int EventTypeId { get; set; }

        /// <summary>
        /// EventStatusId?
        /// </summary>
        //[ValidStatusForServiceEventType("EventTypeId")]
        [Required(ErrorMessage = "Event status id is required.")]
        [ValidStatus]
        public int EventStatusId { get; set; }

        /// <summary>
        /// AssetReplacementReasonId
        /// </summary>
        public int? AssetReplacementReasonId { get; set; }

        /// <summary>
        /// EventDate
        /// </summary>
        [Required(ErrorMessage = "Service event date is required.")]
        public DateTime EventDate { get; set; }

        /// <summary>
        /// NextScheduledDate
        /// </summary>
        //[ValidFutureDate(ErrorMessage = "Next scheduled date must be in the future")]
        public DateTime? NextScheduledDate { get; set; }
        
        /// <summary>
        /// NextCalc
        /// </summary>
        [MaxLength(10, ErrorMessage = "Next calculation cannot be longer than 10 characters.")]
        public string NextCalc { get; set; }

        /// <summary>
        /// Interval
        /// </summary>
        public int? Interval { get; set; }
        
        /// <summary>
        /// IntervalType
        /// </summary>
        [MaxLength(6, ErrorMessage = "Interval type cannot be longer than 6 characters.")]
        public string IntervalType { get; set; }

        /// <summary>
        /// BreakdownCode
        /// </summary>
        [MaxLength(2, ErrorMessage = "Breakdown code cannot be longer than 2 characters.")]
        public string BreakdownCode { get; set; }

        /// <summary>
        /// BreakdownDesc
        /// </summary>
        [MaxLength(50, ErrorMessage = "Breakdown description cannot be longer than 50 characters.")]
        public string BreakdownDesc { get; set; }

        /// <summary>
        /// BreakdownCustomReason
        /// </summary>
        [MaxLength(50, ErrorMessage = "Breakdown custom reason cannot be longer than 50 characters.")]
        public string BreakdownCustomReason { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        [MaxLength(255, ErrorMessage = "Notes cannot be longer than 255 characters.")]
        public string Notes { get; set; }

        /// <summary>
        /// CreatedBy
        /// </summary>
        [DoNotPatch]
        public long CreateBy { get; set; }

        /// <summary>
        /// CreateDate
        /// </summary>
        [DoNotPatch]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// ModifyBy
        /// </summary>
        [DoNotPatch]
        public long ModifyBy { get; set; }

        /// <summary>
        /// ModifyDate
        /// </summary>
        [DoNotPatch]
        public DateTime ModifyDate { get; set; }
    }
}