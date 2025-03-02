// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>A2A enable protection input.</summary>
    [System.ComponentModel.TypeConverter(typeof(A2AEnableProtectionInputTypeConverter))]
    public partial class A2AEnableProtectionInput
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AEnableProtectionInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal A2AEnableProtectionInput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DiskEncryptionInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfo) content.GetValueForProperty("DiskEncryptionInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("FabricObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).FabricObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryContainerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryContainerId = (string) content.GetValueForProperty("RecoveryContainerId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryContainerId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryResourceGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryResourceGroupId = (string) content.GetValueForProperty("RecoveryResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryResourceGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryCloudServiceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryCloudServiceId = (string) content.GetValueForProperty("RecoveryCloudServiceId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryCloudServiceId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryAvailabilitySetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryAvailabilitySetId = (string) content.GetValueForProperty("RecoveryAvailabilitySetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryAvailabilitySetId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryProximityPlacementGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryProximityPlacementGroupId = (string) content.GetValueForProperty("RecoveryProximityPlacementGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryProximityPlacementGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("VMDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).VMDisk = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmDiskInputDetails[]) content.GetValueForProperty("VMDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).VMDisk, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmDiskInputDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AvmDiskInputDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("VMManagedDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).VMManagedDisk = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskInputDetails[]) content.GetValueForProperty("VMManagedDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).VMManagedDisk, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskInputDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AvmManagedDiskInputDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("MultiVMGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).MultiVMGroupName = (string) content.GetValueForProperty("MultiVMGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).MultiVMGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("MultiVMGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).MultiVMGroupId = (string) content.GetValueForProperty("MultiVMGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).MultiVMGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryBootDiagStorageAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryBootDiagStorageAccountId = (string) content.GetValueForProperty("RecoveryBootDiagStorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryBootDiagStorageAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryAvailabilityZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryAvailabilityZone = (string) content.GetValueForProperty("RecoveryAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryAvailabilityZone, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryAzureNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryAzureNetworkId = (string) content.GetValueForProperty("RecoveryAzureNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryAzureNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoverySubnetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoverySubnetName = (string) content.GetValueForProperty("RecoverySubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoverySubnetName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryVirtualMachineScaleSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryVirtualMachineScaleSetId = (string) content.GetValueForProperty("RecoveryVirtualMachineScaleSetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryVirtualMachineScaleSetId, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)this).InstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("DiskEncryptionInfoDiskEncryptionKeyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoDiskEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionKeyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskEncryptionInfoKeyEncryptionKeyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IKeyEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoKeyEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.KeyEncryptionKeyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskEncryptionKeyInfoSecretIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionKeyInfoSecretIdentifier = (string) content.GetValueForProperty("DiskEncryptionKeyInfoSecretIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionKeyInfoSecretIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyInfoKeyIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).KeyEncryptionKeyInfoKeyIdentifier = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).KeyEncryptionKeyInfoKeyIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("DiskEncryptionKeyInfoKeyVaultResourceArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("DiskEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyInfoKeyVaultResourceArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AEnableProtectionInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal A2AEnableProtectionInput(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DiskEncryptionInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfo) content.GetValueForProperty("DiskEncryptionInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("FabricObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).FabricObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryContainerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryContainerId = (string) content.GetValueForProperty("RecoveryContainerId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryContainerId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryResourceGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryResourceGroupId = (string) content.GetValueForProperty("RecoveryResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryResourceGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryCloudServiceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryCloudServiceId = (string) content.GetValueForProperty("RecoveryCloudServiceId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryCloudServiceId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryAvailabilitySetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryAvailabilitySetId = (string) content.GetValueForProperty("RecoveryAvailabilitySetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryAvailabilitySetId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryProximityPlacementGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryProximityPlacementGroupId = (string) content.GetValueForProperty("RecoveryProximityPlacementGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryProximityPlacementGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("VMDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).VMDisk = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmDiskInputDetails[]) content.GetValueForProperty("VMDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).VMDisk, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmDiskInputDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AvmDiskInputDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("VMManagedDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).VMManagedDisk = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskInputDetails[]) content.GetValueForProperty("VMManagedDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).VMManagedDisk, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskInputDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AvmManagedDiskInputDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("MultiVMGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).MultiVMGroupName = (string) content.GetValueForProperty("MultiVMGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).MultiVMGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("MultiVMGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).MultiVMGroupId = (string) content.GetValueForProperty("MultiVMGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).MultiVMGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryBootDiagStorageAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryBootDiagStorageAccountId = (string) content.GetValueForProperty("RecoveryBootDiagStorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryBootDiagStorageAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryAvailabilityZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryAvailabilityZone = (string) content.GetValueForProperty("RecoveryAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryAvailabilityZone, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryAzureNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryAzureNetworkId = (string) content.GetValueForProperty("RecoveryAzureNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryAzureNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoverySubnetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoverySubnetName = (string) content.GetValueForProperty("RecoverySubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoverySubnetName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryVirtualMachineScaleSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryVirtualMachineScaleSetId = (string) content.GetValueForProperty("RecoveryVirtualMachineScaleSetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).RecoveryVirtualMachineScaleSetId, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)this).InstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("DiskEncryptionInfoDiskEncryptionKeyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoDiskEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionKeyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskEncryptionInfoKeyEncryptionKeyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IKeyEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoKeyEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.KeyEncryptionKeyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskEncryptionKeyInfoSecretIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionKeyInfoSecretIdentifier = (string) content.GetValueForProperty("DiskEncryptionKeyInfoSecretIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionKeyInfoSecretIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyInfoKeyIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).KeyEncryptionKeyInfoKeyIdentifier = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).KeyEncryptionKeyInfoKeyIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("DiskEncryptionKeyInfoKeyVaultResourceArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("DiskEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyInfoKeyVaultResourceArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AEnableProtectionInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInput" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new A2AEnableProtectionInput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AEnableProtectionInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInput" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInput DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new A2AEnableProtectionInput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="A2AEnableProtectionInput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="A2AEnableProtectionInput" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInput FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// A2A enable protection input.
    [System.ComponentModel.TypeConverter(typeof(A2AEnableProtectionInputTypeConverter))]
    public partial interface IA2AEnableProtectionInput

    {

    }
}