// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Compute.Models
{
    /// <summary> Describes a virtual machine scale set virtual machine profile. </summary>
    public partial class VirtualMachineScaleSetVMProfile
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMProfile. </summary>
        public VirtualMachineScaleSetVMProfile()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMProfile. </summary>
        /// <param name="osProfile"> Specifies the operating system settings for the virtual machines in the scale set. </param>
        /// <param name="storageProfile"> Specifies the storage settings for the virtual machine disks. </param>
        /// <param name="networkProfile"> Specifies properties of the network interfaces of the virtual machines in the scale set. </param>
        /// <param name="diagnosticsProfile"> Specifies the boot diagnostic settings state. &lt;br&gt;&lt;br&gt;Minimum api-version: 2015-06-15. </param>
        /// <param name="extensionProfile"> Specifies a collection of settings for extensions installed on virtual machines in the scale set. </param>
        /// <param name="licenseType"> Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </param>
        /// <param name="priority"> Specifies the priority for the virtual machines in the scale set. &lt;br&gt;&lt;br&gt;Minimum api-version: 2017-10-30-preview. </param>
        /// <param name="evictionPolicy"> Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set. &lt;br&gt;&lt;br&gt;For Azure Spot virtual machines, the only supported value is &apos;Deallocate&apos; and the minimum api-version is 2019-03-01. &lt;br&gt;&lt;br&gt;For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2017-10-30-preview. </param>
        /// <param name="billingProfile"> Specifies the billing related details of a Azure Spot VMSS. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01. </param>
        /// <param name="scheduledEventsProfile"> Specifies Scheduled Event related configurations. </param>
        internal VirtualMachineScaleSetVMProfile(VirtualMachineScaleSetOSProfile osProfile, VirtualMachineScaleSetStorageProfile storageProfile, VirtualMachineScaleSetNetworkProfile networkProfile, DiagnosticsProfile diagnosticsProfile, VirtualMachineScaleSetExtensionProfile extensionProfile, string licenseType, VirtualMachinePriorityTypes? priority, VirtualMachineEvictionPolicyTypes? evictionPolicy, BillingProfile billingProfile, ScheduledEventsProfile scheduledEventsProfile)
        {
            OsProfile = osProfile;
            StorageProfile = storageProfile;
            NetworkProfile = networkProfile;
            DiagnosticsProfile = diagnosticsProfile;
            ExtensionProfile = extensionProfile;
            LicenseType = licenseType;
            Priority = priority;
            EvictionPolicy = evictionPolicy;
            BillingProfile = billingProfile;
            ScheduledEventsProfile = scheduledEventsProfile;
        }

        /// <summary> Specifies the operating system settings for the virtual machines in the scale set. </summary>
        public VirtualMachineScaleSetOSProfile OsProfile { get; set; }
        /// <summary> Specifies the storage settings for the virtual machine disks. </summary>
        public VirtualMachineScaleSetStorageProfile StorageProfile { get; set; }
        /// <summary> Specifies properties of the network interfaces of the virtual machines in the scale set. </summary>
        public VirtualMachineScaleSetNetworkProfile NetworkProfile { get; set; }
        /// <summary> Specifies the boot diagnostic settings state. &lt;br&gt;&lt;br&gt;Minimum api-version: 2015-06-15. </summary>
        public DiagnosticsProfile DiagnosticsProfile { get; set; }
        /// <summary> Specifies a collection of settings for extensions installed on virtual machines in the scale set. </summary>
        public VirtualMachineScaleSetExtensionProfile ExtensionProfile { get; set; }
        /// <summary> Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </summary>
        public string LicenseType { get; set; }
        /// <summary> Specifies the priority for the virtual machines in the scale set. &lt;br&gt;&lt;br&gt;Minimum api-version: 2017-10-30-preview. </summary>
        public VirtualMachinePriorityTypes? Priority { get; set; }
        /// <summary> Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set. &lt;br&gt;&lt;br&gt;For Azure Spot virtual machines, the only supported value is &apos;Deallocate&apos; and the minimum api-version is 2019-03-01. &lt;br&gt;&lt;br&gt;For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2017-10-30-preview. </summary>
        public VirtualMachineEvictionPolicyTypes? EvictionPolicy { get; set; }
        /// <summary> Specifies the billing related details of a Azure Spot VMSS. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01. </summary>
        public BillingProfile BillingProfile { get; set; }
        /// <summary> Specifies Scheduled Event related configurations. </summary>
        public ScheduledEventsProfile ScheduledEventsProfile { get; set; }
    }
}
